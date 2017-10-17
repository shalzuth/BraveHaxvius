using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;

namespace PacketDecoder
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            /*var dlls = Directory.GetFiles(@"..\PacketDecoder\lib\", "*.dll");
            var exes = Directory.GetFiles(@"..\PacketDecoder\lib\", "*.exe");
            var files = dlls.ToList().Concat(exes.ToList());
            foreach (var file in files)
            {
                var bytes = CompressEncrypt(File.ReadAllBytes(file));
                File.WriteAllBytes(file.Replace(".exe","").Replace(".dll","") + ".gz", bytes);
            }*/
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                var bytes = GetEmbeddedBytes(Assembly.GetExecutingAssembly().GetName().Name + ".lib." + new AssemblyName(args.Name).Name + ".gz");
                if (bytes != null)
                    return Assembly.Load(bytes);
                return null;
            };
            App.Main();
        }
        public static byte[] GetEmbeddedBytes(String file)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(file))
            {
                if (stream != null)
                {
                    var assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);

                    var key = System.Text.Encoding.ASCII.GetBytes("t7n6cVWf9Tbns0eI");
                    var iv = System.Text.Encoding.ASCII.GetBytes("9qh17ZUf");
                    var provider = new System.Security.Cryptography.TripleDESCryptoServiceProvider();
                    var transform = provider.CreateDecryptor(key, iv);
                    byte[] bytes;
                    using (var cstream = new MemoryStream())
                    {
                        using (var cryptoStream = new System.Security.Cryptography.CryptoStream(cstream, transform, System.Security.Cryptography.CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(assemblyData, 0, assemblyData.Length);
                            cryptoStream.FlushFinalBlock();
                            bytes = cstream.ToArray();

                            using (var compressedStream = new MemoryStream(bytes))
                            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                            using (var resultStream = new MemoryStream())
                            {
                                zipStream.CopyTo(resultStream);
                                return resultStream.ToArray();
                            }
                        }
                    }                    
                }
            }
            return null;
        }
        public static byte[] CompressEncrypt(byte[] raw)
        {
            byte[] zippedBytes;
            using (var memory = new MemoryStream())
            {
                using (var gzip = new GZipStream(memory, CompressionMode.Compress, true))
                    gzip.Write(raw, 0, raw.Length);
                zippedBytes = memory.ToArray();
            }
            var key = System.Text.Encoding.ASCII.GetBytes("t7n6cVWf9Tbns0eI");
            var iv = System.Text.Encoding.ASCII.GetBytes("9qh17ZUf");
            var provider = new System.Security.Cryptography.TripleDESCryptoServiceProvider();
            var transform = provider.CreateEncryptor(key, iv);
            using (var stream = new MemoryStream())
            {
                using (var cryptoStream = new System.Security.Cryptography.CryptoStream(stream, transform, System.Security.Cryptography.CryptoStreamMode.Write))
                {
                    cryptoStream.Write(zippedBytes, 0, zippedBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    return stream.ToArray();
                }
            }
        }
    }
}