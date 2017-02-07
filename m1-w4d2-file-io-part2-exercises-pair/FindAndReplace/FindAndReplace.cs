using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindAndReplace
{
    public static class FindAndReplace
    {
        public static void CopyingTakeValue()
        {
            Console.WriteLine("Please input the phrase you want to search: ");
            string phraseToSearch = Console.ReadLine();

            Console.WriteLine("Please input the phrase you want to replace with in the file: ");
            string phraseToReplaceWith = Console.ReadLine();
            string sourcePath = string.Empty;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Please input file source path: ");
                sourcePath = Console.ReadLine();
                if (File.Exists(sourcePath)) isValid = true;

            }

            Console.WriteLine("Please input file destination path: ");
            string outPutPath = Console.ReadLine();
            if (Directory.Exists(Path.GetDirectoryName(outPutPath)) || File.Exists(Path.GetFileName(outPutPath)))
            {
            }
            else
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outPutPath));
                FindToReplace(phraseToSearch, phraseToReplaceWith, sourcePath, outPutPath);
            }
        }

        public static void FindToReplace(string phraseToSearch, string phraseToReplaceWith, string sourcePath, string outPutPath)
        {
            using (StreamReader sr = new StreamReader(sourcePath))
            {
                using (StreamWriter sw = new StreamWriter(outPutPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Contains(phraseToSearch)) line = line.Replace(phraseToSearch, phraseToReplaceWith);
                        sw.WriteLine(line);

                    }

                }
            }
        }

    }
}


//C:\Users\cmedrano\playground\week4team2-c-week4-pair-exercises\m1-w4d2-file-io-part2-exercises-pair\alices_adventures_in_wonderland.txt
//C:\Users\cmedrano\playground\week4team2-c-week4-pair-exercises\m1-w4d2-file-io-part2-exercises-pair\xxxxxx.txt