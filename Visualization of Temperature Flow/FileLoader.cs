using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualization_of_Temperature_Flow
{
    class FileLoader
    {
        public static void LoadFiles()
        {
            string sourceString = Environment.CurrentDirectory;

            string fileName = "TemperatureFlowC++.dll";
            string sourcePath = Directory.GetParent(sourceString).Parent.Parent.FullName + "\\Release";
            string targetPath = @"C:\VisualizationFiles";

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            System.IO.File.Copy(sourceFile, destFile, true);
        }
    }
}
