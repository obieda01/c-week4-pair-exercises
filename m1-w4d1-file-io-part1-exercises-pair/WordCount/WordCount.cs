﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
   public static class WordCount
    {
        public static void wordSentenceCounter()
        {
            Console.WriteLine("Please input the file path:");
            string filePath = Console.ReadLine();
            while (!File.Exists(filePath))
            {
                Console.WriteLine("Please input the RIGHT file path:");
                filePath = Console.ReadLine();
            }
            int wordsCount = 0;
            int sentenceCount = 0;
            try
            {
                using (StreamReader fileReader = new StreamReader(filePath))
                {
                    while (!fileReader.EndOfStream)
                    {
                        string[] sentences = fileReader.ReadToEnd().Split(new char[] { '.', '!', '?' });

                        sentenceCount = sentences.Length;
                        foreach (var item in sentences)
                        {
                            if (!(item == "" || item == " "))
                            {
                                string[] words = item.Split(' ');
                                wordsCount += words.Length;
                            }
                            else sentenceCount--;
                        }


                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ooops! there is an Exception: " + e.Message);
            }

            Console.WriteLine(wordsCount + "                 " + sentenceCount);
            Console.ReadKey();


            //  C: \Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d1-file-io-part1-exercises-pair\alices_adventures_in_wonderland.txt
            //  if (!Directory.Exists(filePath)) throw new DirectoryNotFoundException("your path is wrong");
            //  C: \Users\aobiedat\Tech Elevator\.Net class\week1\c-week4-pair-exercises\m1-w4d1-file-io-part1-exercises-pair\testfile.txt


        }
    }
}
