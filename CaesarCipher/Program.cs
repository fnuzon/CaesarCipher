using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int input;
            string text;
            string encryptedText;
            int cycle = 0;           
            do
            {

               
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. to enter text to encrypt");
                Console.WriteLine("2. to cycle alphabets");
                Console.WriteLine("3. decrypt text");
                input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Give text: ");
                    text = Console.ReadLine();
                    encryptedText = Algorithm.stringAlphabet(text);
                    Console.WriteLine("Encrypted text: ");
                    Console.WriteLine(encryptedText);
                }
                if (input == 2)
                {
                    Console.WriteLine("Give value how much to cycle alphabets");
                    cycle = int.Parse(Console.ReadLine());                    
                    Algorithm.ChangeKey = cycle;
                }
                if (input == 3)
                {
                    Console.WriteLine("Give text to decrypt");
                    text = Console.ReadLine();
                    Algorithm.decrypt(text);
                }
            }
            while (input != 0);

            
        }
    }
}
