using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SixLabors.ImageSharp;

namespace ConverIt.Core
{
    public class ImageConverter : IFileConverter
    {

        public void Convert(string inputFilePath, string outputFilePath)
        {
            using (Image image = Image.Load(inputFilePath))
            {
                image.Save(outputFilePath);
            }
            

        }
    }
}
