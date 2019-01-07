using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptingAlgorithm
{
    public class secure 
    {
        public static string Encrypt(string Value)
        {

            Char[] charArry = Value.ToCharArray();

            Array.Reverse(charArry);


            string s = new string(charArry);
            s = shiftRight(3, s);

            //leftpad and Rightpad array with numbers 
            s = "123" + s + "321";
            return s;
        }

        private static string shiftRight(int numberOfPlaces, string Value)
        {
            string s = Value;

            int sLastcharslen = (s.Length - numberOfPlaces);
            string sRemaining = s.Substring(0, sLastcharslen);


            string sLast = s.Substring((sRemaining.Length), (s.Length - sRemaining.Length));
            s = sLast + sRemaining;

            return s;
        }


        public static string Decrypt(string Value)
        {

            string s = Value;
            s = s.Substring(3);
            s = s.Substring(0, (s.Length - 3));
            //s=s.TrimStart('1','2','3');

            //s = s.TrimEnd('3','2','1');

            s = shiftLeft(3, s);
            Char[] charArry = s.ToCharArray();

            Array.Reverse(charArry);

            return new string(charArry);
        }

        private static string shiftLeft(int numberOfPlaces, string Value)
        {
            string s = Value;

            string sFirst = s.Substring(0, numberOfPlaces);
            string sRemaining = s.Substring(numberOfPlaces, (s.Length - sFirst.Length));
            s = sRemaining + sFirst;

            return s;
        }


    }
}
