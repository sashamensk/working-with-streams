using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#pragma warning disable CA1062

namespace WorkingWithStreams
{
    public static class ReadingFromStream
    {
        public static string ReadAllStreamContent(StreamReader c)
        {
            return c.ReadToEnd();
        }

        public static string[] ReadLineByLine(StreamReader streamReader)
        {
            var list = new List<string>();
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                list.Add(line);
            }

            return list.ToArray();
        }

        public static StringBuilder ReadOnlyLettersAndNumbers(StreamReader streamReader)
        {
            StringBuilder result = new StringBuilder();
            int index = 0;
            while ((index = streamReader.Peek()) > -1)
            {
                if (!char.IsLetterOrDigit((char)index))
                {
                    break;
                }
                else
                {
                    streamReader.Read();
                    result.Append((char)index);
                }
            }

            return result;
        }

        public static char[][] ReadAsCharArrays(StreamReader streamReader, int arraySize)
        {
            string str = streamReader.ReadToEnd();
            int numOfRows = str.Length / arraySize;
            int addRowLen = str.Length % arraySize;

            char[][] arr;

            if (addRowLen == 0)
            {
                arr = new char[numOfRows][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new char[arraySize];
                }
            }
            else
            {
                arr = new char[numOfRows + 1][];

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = new char[arraySize];
                }

                arr[^1] = new char[addRowLen];
            }

            int index = 0;

            foreach (var raw in arr)
            {
                for (int i = 0; i < raw.Length; i++)
                {
                    raw[i] = str[index];
                    index++;
                }
            }

            return arr;
        }
    }
}
