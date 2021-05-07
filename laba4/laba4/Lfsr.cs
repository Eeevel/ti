using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba4
{
    class Lfsr
    {
        private ulong lfsr;
        private const int BUFFER_LENGTH = 1024;
        private const int NUMBER_OF_BITS = 8;

        public Lfsr(ulong key)
        {
            lfsr = key;
        }

        public void Treatment(string srcFile, string dstFile)
        {
            if (File.Exists(dstFile))
                File.Delete(dstFile);

            var reader = new BinaryReader(File.Open(srcFile, FileMode.Open));
            var writer = new BinaryWriter(File.Open(dstFile, FileMode.Create));

            var buffer = new byte[BUFFER_LENGTH];
            int size;
            do
            {
                size = reader.Read(buffer, 0, BUFFER_LENGTH);
                for (var i = 0; i < BUFFER_LENGTH; ++i)
                {
                    for (var j = 0; j < NUMBER_OF_BITS; ++j)
                    {
                        buffer[i] = (byte)(buffer[i] ^ (GetBit() << NUMBER_OF_BITS - 1 - j));
                    }
                }

                writer.Write(buffer, 0, size);

            } while (size > 0);
            
            reader.Close();
            writer.Close();
        }

        // x^26 + x^8 + x^7 + x + 1
        private ulong GetBit()
        {
            var result = lfsr >> 31;

            var bit25 = (lfsr >> 25) & 1;
            var bit7 = (lfsr >> 7) & 1;
            var bit6 = (lfsr >> 6) & 1;
            var bit0 = lfsr & 1;
            var xor = bit0 ^ bit6 ^ bit7 ^ bit25;

            lfsr = (lfsr << 1) | xor;

            return result;
        }
    }
}
