// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");


// string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
//       string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels",
//                          "Abraham Adams", "Ms. Nicole Norris" };
//       foreach (string name in names)
//          Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

string patternAppInnovation = "((?i)app)*?((?i)inn).*?";
string patternAppModernization = "((?i)app).*?((?i)mod).*?";
string patternRFx = @"((?i)app).*?((?i)mod).*?";

string OneAskTitle1 = "need help with application modernization project";
OneAskTitle1 = "app od";
string OneAskTitle2 = "need help with pplication modernization project";
string OneAskTitle3 = "need help with pplication Innovation project";

if (Regex.IsMatch(OneAskTitle1,patternAppModernization))
    Console.WriteLine("Match 1!");
else 
    Console.WriteLine("No Match 1!");

if (Regex.IsMatch(OneAskTitle2,patternAppModernization))
    Console.WriteLine("Match 2!");
else 
    Console.WriteLine("No Match 2!");

if (Regex.IsMatch(OneAskTitle3,patternAppModernization)||Regex.IsMatch(OneAskTitle3,patternAppInnovation))
    Console.WriteLine("Match 3!");
else 
    Console.WriteLine("No Match 3!");


   