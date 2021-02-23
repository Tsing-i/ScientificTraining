using System.Diagnostics;
using System.IO;

namespace ModuleLogic
{
    public class ReadConfigure
    {
        public static string ReadParameter(string fileName)
        {
            var file = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + fileName;
            string line = "";
            using (StreamReader sr = new StreamReader(file))
            {
                line = sr.ReadLine();
            }
            return line;
        }
    }
}
