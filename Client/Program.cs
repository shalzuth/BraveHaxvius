using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*var dlls = Directory.GetFiles(@".\", "*.dll");
            var files = dlls.ToList().Concat(dlls.ToList());
            foreach (var file in files)
            {
                var bytes = CompressEncrypt(File.ReadAllBytes(file));
                File.WriteAllBytes(@"..\Client\lib\" + file.Replace(".dll","") + ".gz", bytes);
            }*/
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                var bytes = GetEmbeddedBytes("Client.lib." + new AssemblyName(args.Name).Name + ".gz");
                if (bytes != null)
                    return Assembly.Load(bytes);
                return null;
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public static byte[] GetEmbeddedBytes(String file)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(file))
            {
                if (stream != null)
                {
                    var assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    using (var compressedStream = new MemoryStream(assemblyData))
                    using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
                    using (var resultStream = new MemoryStream())
                    {
                        zipStream.CopyTo(resultStream);
                        return resultStream.ToArray();
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
                return zippedBytes;
            }
        }
    }
}
