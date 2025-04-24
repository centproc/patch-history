using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

Console.Write("Enter date (YYYY-MM-DD): ");
var dateInput = Console.ReadLine()?.Trim();

Console.Write("Enter short name for file: ");
var nameInput = Console.ReadLine()?.Trim()?.ToLower().Replace(" ","-");

// Validating and generating name
if(string.IsNullOrWhiteSpace(dateInput) || string.IsNullOrWhiteSpace(nameInput))
{
    Console.WriteLine("Invalid name input - exiting");
    return;
}

var fileName = $"{dateInput}-{nameInput}.md";

// Number of sections
Console.Write("How many sections to be included? (Minimum of 1 required)");
if(!int.TryParse(Console.ReadLine(), out int sectionAmt) || sectionAmt < 1)
{
    Console.WriteLine("Invalid input given - exiting.");
    return;
}

// Content section
var sb = new StringBuilder();

sb.AppendLine($"# {dateInput} - {nameInput.Replace("-", " ").ToUpperInvariant()}");
sb.AppendLine("---");
sb.AppendLine("<br>");
sb.AppendLine();
sb.AppendLine("<h3 id=\"top\">General Changes</h3>");
sb.AppendLine("<strong><a href=\"\" style=\"text-decoration: none;\">back to patch list</a></strong>")
sb.AppendLine();
sb.AppendLine();
sb.AppendLine();
sb.AppendLine("<table class=\"table-style\">");
sb.AppendLine("<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>");
sb.AppendLine("<tbody>");
sb.AppendLine("<tr><td></td><td></td><td></td></tr>");
sb.AppendLine("</tbody>");
sb.AppendLine("</table>");
sb.AppendLine();
sb.AppendLine("<!-- Section Index -->");
sb.AppendLine("<h3>Specific character updates this patch</h3>");
sb.AppendLine("<table class=\"character-table-style\">");
sb.AppendLine("<tbody>");
sb.AppendLine("<tr><td></td><td></td><td></td><td></td></tr>");
sb.AppendLine("</tbody>");
sb.AppendLine("</table>");
sb.AppendLine();
sb.AppendLine("---");
sb.AppendLine();

var sections = new List<string>();
for (int i = 0; i < sectionAmt; i++)
{
    Console.Write($"Name for section #{i + 1}: ");
    var sectionName = Console.ReadLine()?.Trim();
    if(!string.IsNullOrWhiteSpace(sectionName))
    {
        sections.Add(sectionName);
    }
}

foreach(var section in sections)
{
    var anchor = section.ToLower().Replace(" ","-");
    sb.AppendLine($"<h2 id=\"{anchor}\">{section}</h2>");
    sb.AppendLine("<table class=\"table-style\">");
    sb.AppendLine("<thead><tr><th>Changes</th><th>Category</th><th>Adjustment Details</th></tr></thead>");
    sb.AppendLine("<tbody>");
    sb.AppendLine("<tr><td></td><td></td><td></td></tr>");
    sb.AppendLine("</tbody>");
    sb.AppendLine("</table>");
    sb.AppendLine();
    sb.AppendLine("<strong><a href=\"#top\" style=\"text-decoration: none;\">return to top</a></strong> - <strong><a href=\"\" style=\"text-decoration: none;\">back to patch list</a></strong>");
    sb.AppendLine();
}

// File write
File.WriteAllText(fileName, sb.ToString());
Console.WriteLine($"MD file generated: {fileName}");