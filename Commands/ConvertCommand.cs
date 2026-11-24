
using ConverIt.Core;
using System;
using System.IO;

namespace ConverIt.Commands
{
    public class ConvertCommand : ICommand
    {
        public void Execute(ParsedCommand command, Logger logger)
        {
            if (command.Arguments.Count == 0)
            {
                throw new ArgumentException("No input file specified.");
            }

            if (!command.Options.TryGetValue("to", out string targetFormat)
                || string.IsNullOrWhiteSpace(targetFormat))
            {
                throw new ArgumentException(
                    "No target format specified. Use --to option to specify the target format.");
            }

            string inputPath = command.Arguments[0];

            targetFormat = targetFormat.Trim().TrimStart('.').ToLowerInvariant();

            string outputPath = Path.ChangeExtension(inputPath, targetFormat);


            if (!File.Exists(inputPath))
            {
                throw new FileNotFoundException("Input file not found.", inputPath);
            }
            if (File.Exists(outputPath))
            {
                throw new IOException($"Output file '{outputPath}' already exists.");
            }



            string extension = Path.GetExtension(inputPath).ToLowerInvariant();

            IFileConverter converter;

            string[]ImageExtentions =
            {
                ".png" , ".jpg" , ".jpeg" , ".gif" ,".bmp" , ".webp" , ".tiff"
            };

            string[] VideoExtintions =
            {
                ".mp4" , ".avi" , ".mkv" , ".mov" , ".wmv" , ".flv" ,".webm"
            };


            if (Array.Exists(ImageExtentions , ext => ext == extension))
            {
                converter = new ImageConverter();
            }
            else if (Array.Exists(VideoExtintions , ext => ext == extension))
            {
                converter = new VideoConverter();
            }
            else
            {
                throw new NotSupportedException("Unsupported file format.");
            }

            converter.Convert(inputPath, outputPath);


            logger.Success("Conversion Completed successfully");
        }
    }
}
