
using System;
using System.Diagnostics;
using System.IO;

namespace ConverIt.Core
{
    public class VideoConverter : IFileConverter
    {
        public void Convert(string inputFilePath, string outputFilePath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = @"H:\Learning\Programming\ConverIt\ffmpeg-2026-11-23-git-05c674c913-full_build\ffmpeg-2026-11-23-git-05c674c913-full_build\bin\ffmpeg.exe";

            startInfo.Arguments =
                "-hide_banner -loglevel error -i \"" +
                inputFilePath + "\" -n \"" + outputFilePath + "\"";

            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;

            using (Process process = new Process())
            {
                process.StartInfo = startInfo;
                process.Start();

                string error = process.StandardError.ReadToEnd();

                process.WaitForExit();

                if (process.ExitCode != 0)
                    throw new InvalidOperationException(
                        "Video conversion failed: " + error);
            }

            if (!File.Exists(outputFilePath))
                throw new IOException("Output file was not created.");
        }
    }
}
