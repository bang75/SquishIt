using System;
using SquishIt.Framework.Files;

namespace SquishIt.Framework.Tests.Mocks
{
    public class StubFileReader: IFileReader
    {
        private readonly string file;
        private readonly string contents;

        public string File
        {
            get { return file; }
        }

        public StubFileReader(string file, string contents)
        {
            this.file = file;
            this.contents = contents;
        }

        public void Dispose()
        {            
        }

        public string ReadLine()
        {
            return contents;
        }

        public string ReadToEnd()
        {
            return contents;
        }
    }
}