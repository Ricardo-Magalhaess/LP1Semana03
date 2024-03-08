using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tell me something");
            string s = Console.ReadLine();
            Console.WriteLine("give me one character");
            string Scar = Console.ReadLine();
            char car = char.Parse(Scar);
            char write;
            string news = "";
            for (int i = 0; i <  s.Length; i++){
                write = str[i];
                if (s[i] == car){
                    write = 'X';
                }
                newstr += write;
            }
            Console.WriteLine(newstr);
        }
    }
}
