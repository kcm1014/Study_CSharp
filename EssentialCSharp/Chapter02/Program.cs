// See https://aka.ms/new-console-template for more information
#nullable disable
string firstName = "kang";
string lastName = "Coding";


Console.WriteLine(string.Format("Your full name is {0} {1}.",firstName,lastName));
Console.WriteLine($"Your full name is {firstName} {lastName}");
//Console.WriteLine("Your full name {0} {1}".Format(firstName,lastName));


int a = (int)123L;
int c = System.Convert.ToInt32(123L);