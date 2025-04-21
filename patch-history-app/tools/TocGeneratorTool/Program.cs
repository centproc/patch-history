
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Collections.Generic;

var root = "patch-history-app/wwwroot/docs";
Console.WriteLine("Current path: " + Path.GetFullPath(root));
Console.WriteLine("Getting current Directory: " + Directory.GetCurrentDirectory());
var gameDirs = Directory.GetDirectories(root);

var docToc = new List<object>();

foreach (var game in gameDirs)
{
    var gameName = Path.GetFileName(game);
    var gameSlug = gameName.ToLower().Replace(" ","-");

    docToc.Add(new
    {
        Title = gameName,
        Slug = gameSlug
    });

    var markdownFiles = Directory.GetFiles(game, "*.md");
    var gameToc = new List<(string Title, string Slug, DateTime Date)>();

    foreach (var file in markdownFiles)
    {
        var lines = File.ReadLines(file);
        string? heading = null;
        DateTime date = DateTime.MinValue;

        foreach (var line in lines)
        {
            if (line.StartsWith("#"))
            {
                heading = line.TrimStart('#',' ').Trim();
                var match = Regex.Match(heading, @"\b(\d{4}-\d{2}-\d{2})\b");
                if(match.Success)
                {
                    DateTime.TryParse(match.Value, out date);
                }
                break;
            }
        }

        var fallback = Path.GetFileNameWithoutExtension(file);
        var title = heading ?? fallback;
        var slug = fallback.ToLower().Replace(" ","-");

        gameToc.Add((Title: title, Slug: slug, Date: date ));
    }

    var sortToc = gameToc
        .OrderByDescending(entry => entry.Date)
        .Select(entry => new { entry.Title, entry.Slug })
        .ToList();

    var gameTocLocation = Path.Combine(game, "toc.json");
    var gameJson = JsonSerializer.Serialize(sortToc, new JsonSerializerOptions {WriteIndented = true});
    File.WriteAllText(gameTocLocation, gameJson);
    Console.WriteLine($"Generated toc.json for {gameName}");
}

// Writing the top level toc.json
var docJson = JsonSerializer.Serialize(docToc, new JsonSerializerOptions {WriteIndented = true});
File.WriteAllText(Path.Combine(root, "toc.json"),docJson);
Console.WriteLine("Generated top level toc.json");