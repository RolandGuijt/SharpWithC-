var language = "en";
//Three quotes: no need to repeat " in the string
//also: interpolated use still supported
var htmlTag = $"""<html lang="{language}"/>""";
Console.WriteLine(htmlTag);

var logLevel = "Information";
//multi line example. Output indentation depends on indent position of ending quotes
//interpolated strings need $$ here because {} is already used in content
var json = $$"""
    {
      "Logging": {
          "LogLevel": {
              "Default": "{{logLevel
                .ToLower()}}"
          }
      }
    }
    """;
Console.WriteLine(json);



