using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace WorkingWithStreams
{
    public static class CreatingReaderWriters
    {
        public static StringReader CreateStringReader(string str)
        {
            StringReader result = new StringReader(str);
            return result;
        }

        public static StringWriter CreateStringWriter()
        {
            StringWriter result = new StringWriter();
            return result;
        }

        public static StringWriter CreateStringWriterThatWritesToStringBuilder(StringBuilder stringBuilder)
        {
            StringWriter result = new StringWriter(stringBuilder);
            return result;
        }

        public static StringWriter CreateStringWriterThatWritesCultureSpecificData(CultureInfo cultureInfo)
        {
            StringWriter result = new StringWriter(cultureInfo);
            return result;
        }

        public static StreamReader CreateStreamReaderFromStream(Stream stream)
        {
            StreamReader result = new StreamReader(stream);
            return result;
        }

        public static StreamWriter CreateStreamWriterToStream(Stream stream)
        {
            StreamWriter result = new StreamWriter(stream);
            return result;
        }
    }
}
