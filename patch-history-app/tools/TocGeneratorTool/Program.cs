
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
    var gameToc = new List<object>();

    foreach (var file in markdownFiles)
    {
        var lines = File.ReadLines(file);
        string? heading = null;

        foreach (var line in lines)
        {
            var match = Regex.Match(line,@"^#\s+(.*)");
            if (match.Success)
            {
                heading = match.Groups[1].Value.Trim();
                break;
            }
        }

        var fallback = Path.GetFileNameWithoutExtension(file);
        var title = heading ?? fallback;
        var slug = fallback.ToLower().Replace(" ","-");

        gameToc.Add(new{ Title = title, Slug = slug });
    }

    var gameTocLocation = Path.Combine(game, "toc.json");
    var gameJson = JsonSerializer.Serialize(gameToc, new JsonSerializerOptions {WriteIndented = true});
    File.WriteAllText(gameTocLocation, gameJson);
    Console.WriteLine($"Generated toc.json for {gameName}");
}

// Writing the top level toc.json
var docJson = JsonSerializer.Serialize(docToc, new JsonSerializerOptions {WriteIndented = true});
File.WriteAllText(Path.Combine(root, "toc.json"),docJson);
Console.WriteLine("Generated top level toc.json");