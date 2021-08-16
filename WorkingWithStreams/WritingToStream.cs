using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#pragma warning disable CA1062 // Validate arguments of public methods

namespace WorkingWithStreams
{
    public static class WritingToStream
    {
        public static void ReadAndWriteIntegers(StreamReader streamReader, StreamWriter outputWriter)
        {
            int num;
            string str = string.Empty;
            while ((num = streamReader.Read()) != -1)
            {
                str += num;
            }

            outputWriter.Write(str);
        }

        public static void ReadAndWriteChars(StreamReader streamReader, StreamWriter outputWriter)
        {
            // TODO #5-2. Implement the method by reading a character from the StreamReader and writing it to the outputStream with StreamWriter.Write() method.
            int num;
            List<char> list = new List<char>();
            while ((num = streamReader.Read()) != -1)
            {
                list.Add((char)num);
            }

            outputWriter.Write(list.ToArray());
            outputWriter.Flush();
        }

        public static void TransformBytesToHex(StreamReader contentReader, StreamWriter outputWriter)
        {
            int num;
            while ((num = contentReader.Peek()) > -1)
            {
                outputWriter.Write("0{0:X}", num);
                contentReader.Read();
            }
        }

        public static void WriteLinesWithNumbers(StreamReader contentReader, StreamWriter outputWriter)
        {
            int index = 1;
            while (contentReader.Peek() > -1)
            {
                outputWriter.Write("00{0} {1}\r\n", index, contentReader.ReadLine());
                index++;
            }

            outputWriter.Flush();
        }

        public static void RemoveWordsFromContentAndWrite(StreamReader contentReader, StreamReader wordsReader, StreamWriter outputWriter)
        {
            // TODO #5-5. Implement the method by reading the content and words, removing words from the content, and writing the updated content to the outputWriter. Use StreamReader.Peek method for checking whether there are more characters in the underlying string.
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            while (contentReader.Peek() > -1)
            {
                sb.Append((char)contentReader.Read());
            }

            while (wordsReader.Peek() > -1)
            {
                list.Add(wordsReader.ReadLine());
            }

            foreach (string word in list)
            {
                sb.Replace(word, string.Empty);
            }

            outputWriter.Write(sb);
        }
    }
}
