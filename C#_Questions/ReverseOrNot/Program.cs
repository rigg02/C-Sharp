using System;
string ReverseAndNot(string str)
{
    string rev = new string(str.Reverse().ToArray());
    rev = rev + str;
    return (rev);
}
Console.WriteLine("Enter a string to be reversed and not");
string org;
org = Console.ReadLine();
string rev = ReverseAndNot(org);
Console.WriteLine(rev);