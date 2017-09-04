using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Algorithm
    {
        public const string a = "abcdefghijklmnopqrstuvwxyz";
        public static int forward = 0;
        
        public static int ChangeKey
        {
            get {

                return forward;

                }
            set {

                forward = value;

                }
        }
        public static char forwardAlphabet(char i)
        {
            var pointer = a.IndexOf(i);
            if (pointer == -1)
            {
                return i;
            }
            pointer = ((pointer + forward) + a.Length) % a.Length;
            return a[pointer];

        }
        public static string stringAlphabet(string x)
        {
            return new string(x.Select(forwardAlphabet).ToArray());
        }

        public static void decrypt(string x)
        {
            ChangeKey = (forward - 2 * forward);
            var decryptedText = stringAlphabet(x);
            Console.WriteLine("Decrypted text is:" + decryptedText);
        }
    }
}
