// See https://aka.ms/new-console-template for more information
(string country, string capital, double gdpPerCaital) = ("South Sudan","Juba",275.18);
(string country, string capital, double gdpPerCaital) countryInfo = ("South Sudan","Juba",275.18);
var countryInfo2 = (Name:"South Korea",Capital:"Seoul",gdpPerCaital:40000);

Console.WriteLine($"{country} {capital} {gdpPerCaital}");
Console.WriteLine($"{countryInfo.country} {countryInfo.capital} {countryInfo.gdpPerCaital}");

Console.WriteLine($"{countryInfo2.Name} {countryInfo2.Capital} {countryInfo2.gdpPerCaital}");
Console.WriteLine($"{countryInfo2.Item1} {countryInfo2.Item2} {countryInfo2.Item3}");

