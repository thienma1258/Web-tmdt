using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services.Logging
{
    public class Logging
    {
        public void ErrorLogs(string Message)
        {
            var ErrorLogsFile= System.IO.Path.Combine(Directory.GetCurrentDirectory() + "\\Errorlogs.txt");
            if (!File.Exists(ErrorLogsFile))
            {
                var file=File.Create(ErrorLogsFile);
                file.Close();
            }
            File.AppendAllText(ErrorLogsFile, Message + Environment.NewLine);

        }

    }
}
