using System;
using System.Text;
    (bool,int) palindrome(string pal)
    {
        bool state;
        string test=pal.ToUpper();
        var build = new StringBuilder();
        foreach(char c in test)
        {
            if(!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
            {
                build.Append(c);
            }    
        }
        test=build.ToString();
        int i=0,j=test.Length-1;
        while(i<=j)
        {
            if(test[i]!=test[j])
            {
                return(false,0);
            }
            i++;
            j--;
        }
        return(state,pal.Length);
    }
    Console.WriteLine("Welcome to the program of palindrome");
    Console.WriteLine("Enter a string to check if it is a palindrome");
    string pal=Console.ReadLine();
    (bool b,int l) result= palindrome(pal);
    Console.WriteLine("The result is\n Palindrome: "+result.b+"\nLength: "+result.l);
