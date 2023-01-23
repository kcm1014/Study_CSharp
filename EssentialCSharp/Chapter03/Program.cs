// See https://aka.ms/new-console-template for more information
(string country, string capital, double gdpPerCaital) = ("South Sudan","Juba",275.18);
(string country, string capital, double gdpPerCaital) countryInfo = ("South Sudan","Juba",275.18);

Console.WriteLine($"{country} {capital} {gdpPerCaital}");
Console.WriteLine($"{countryInfo.country} {countryInfo.capital} {countryInfo.gdpPerCaital}");
