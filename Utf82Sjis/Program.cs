using System.IO;
using System.Text;

namespace Utf82Sjis
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var dstPath in args)
            {
                try
                {
                    if (!File.Exists(dstPath)) continue;

                    var name = Path.GetFileNameWithoutExtension(dstPath) + "_sjis" + Path.GetExtension(dstPath);
                    var path = Path.Combine(Path.GetDirectoryName(dstPath), name);

                    var data = File.ReadAllText(dstPath);
                    File.WriteAllText(path, data, Encoding.Default);
                }
                catch { }
            }
        }
    }
}
