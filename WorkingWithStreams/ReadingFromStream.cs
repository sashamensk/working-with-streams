using System;
using System.IO;
using System.Text;

#pragma warning disable CA1062

namespace WorkingWithStreams
{
    public static class ReadingFromStream
    {
        public static string ReadAllStreamContent(StreamReader streamReader)
        {
            // TODO #4-1. Implement the method by reading all content as a stream.
            throw new NotImplementedException();
        }

        public static string[] ReadLineByLine(StreamReader streamReader)
        {
            // TODO #4-2. Implement the method by reading lines of characters as a string array.
            throw new NotImplementedException();
        }

        public static StringBuilder ReadOnlyLettersAndNumbers(StreamReader streamReader)
        {
            // TODO #4-3. Implement the method by reading only letters and numbers, and write the characters to a StringBuilder.
            throw new NotImplementedException();
        }

        public static char[][] ReadAsCharArrays(StreamReader streamReader, int arraySize)
        {
            // TODO #4-4. Implement the method by returning an underlying string that sliced into jagged array of characters according to arraySize.
            throw new NotImplementedException();
        }
    }
}
