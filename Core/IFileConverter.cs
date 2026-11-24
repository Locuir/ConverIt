using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverIt.Core
{
    public interface IFileConverter
    {

        void Convert(string inputFilePath, string outputFilePath);
    }
}
