/*
 * Name: Dmitry Landy
 * Date: 4/24/2021
 * File: Ex14-Cipher.cs
 */

using System;

namespace ex14_encryptCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            //Get Plain Text
            var textStr = Console.ReadLine();

            Console.Write("Enter a single key: ");
            //Get Plain Text
            var singleKey = Console.ReadLine();

            Console.Write("Enter a multi key: ");
            //Get Plain Text
            var multiKey = Console.ReadLine();

            Crypto crypt1 = new Crypto(textStr, singleKey, multiKey);           

            Console.WriteLine(crypt1);            
        }        
    }

	class Crypto
    {        
        private string message { get; set; }
        private string singleKey;
        private string multiKey;       
        private string originalMessage;
        private string contKey;        

        public Crypto(string message, string singleKey, string multiKey)
        {   
            //normalize                       
            message = message.ToUpper();
            singleKey = singleKey.ToUpper();
            multiKey = multiKey.ToUpper();
            message = Regex.Replace(message, "[^A-Z]", "");
            multiKey = Regex.Replace(multiKey, "[^A-Z]", "");

            //assigns to properties and fields
            this.message = message;
            this.singleKey = singleKey;
            this.multiKey = multiKey;            
            originalMessage = message;
            contKey = multiKey + originalMessage;
        }

        public string transformMessage(int direction, string key, string encrypted = "", bool contFlag = false)
        {
            //if decrypting, use encrypted message
            if (direction == 1) message = encrypted; //use encrypted message
            else message = originalMessage; // use unecrypted message

            //get numeric version of key(s)
            List<int> keyNums = getKeyNums(key);                    

            return transform(direction, message, keyNums, contFlag);//0= encrypt, 1=decrypt            
        }

        //Encrypts or decrypts message based on direction.
        private static string transform(int direction, string message, List<int> keyNums, bool contFlag = false)
        {
            int counter = 0;
            StringBuilder newText = new StringBuilder();            

            foreach (var letter in message)
            {
                counter = counter % keyNums.Count;//loops through the key list
                int change = keyNums[counter] - 64;//gets the change value
                int current = (int)letter;//gets ASCII Value of current letter      

                //decrypts or encrypts
                current = direction == 0 ? current += change : current -= change; 

                //between 65-90 inclussive
                if (current < 65) current = 91 - (65 - current);
                else if (current > 90) current = 64 + (current - 90);

                newText.Append((char)current); //add the new character to the new string
                if (contFlag) keyNums.Add(current);

                counter++;
            }
            return newText.ToString();
        }

        //Loops through the key and converts it to ASCII Values. Returns list of values
        private static List<int> getKeyNums(string key)
        {
            List<int> keyNum = new List<int>();

            foreach (var item in key)
            {
                keyNum.Add((int)item);
            }
            return keyNum;
        }

        public override string ToString()
        {
            var encryptedSingle = transformMessage(0, singleKey);
            var encryptedMulti = transformMessage(0, multiKey);
            var encryptedCont= transformMessage(0, contKey);

            var decryptedSingle = transformMessage(1, singleKey, encryptedSingle);
            var decryptedMulti = transformMessage(1, multiKey, encryptedMulti);
            var decryptedCont = transformMessage(1, multiKey, encryptedCont, true);

            return $"" +
                $"Original Message: {originalMessage}\n" +
                $"Single Key: {singleKey}\n" +
                $"Multi Key: {multiKey}\n" +
                $"\n" +
                $"Encrypted with:\n" +
                $"\tSingle Key: {encryptedSingle}\n" +
                $"\tMulti Key: {encryptedMulti}\n" +
                $"\tContinuous Key: {encryptedCont}\n" +
                $"\n" +
                $"Decrypted with:\n" +
                $"\tSingle Key: {decryptedSingle}\n" +
                $"\tMulti Key: {decryptedMulti}\n" +
                $"\tContinuous Key: {decryptedCont}\n";
        }
    }
}
