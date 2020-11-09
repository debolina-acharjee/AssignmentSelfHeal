using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Data_IE
{
    class Application

    {
        public static ulong GetDirectorySize(string folderPath)

        {

            ulong length = (ulong)Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length));

            return length;

        }
        public static ulong EmptyFolder(string directoryName)

        {

            ulong accum = 0;

            DirectoryInfo directory = new DirectoryInfo(directoryName);

            foreach (FileInfo file in directory.GetFiles())

            {

                try

                {

                    accum += (ulong)file.Length;

                    file.Delete();

                }

                catch

                {

                    accum -= (ulong)file.Length;
//file exists
                }



            }

            foreach (DirectoryInfo subDirectory in directory.GetDirectories())

            {

                ulong subDirectorySize = GetDirectorySize(subDirectory.FullName);

                try

                {

                    accum += subDirectorySize;

                    EmptyFolder(subDirectory.FullName);

                    subDirectory.Delete(true);

                }

                catch

                {

                    accum -= subDirectorySize;

                }

            }

            return accum;
        }
        public static string GetIEVersion()

        {

            string getIE64BitPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles) + @"\internet explorer\iexplore.exe";

            string getIE32BitPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFilesX86) + @"\Internet Explorer\iexplore.exe";



            if (File.Exists(getIE64BitPath))

            {

                GetIEPath = getIE64BitPath;

                return "64";

            }



            else if (File.Exists(getIE32BitPath))

            {

                GetIEPath = getIE32BitPath;

                return "32";

            }

            return "NOT FOUND";

        }
        public static string GetIEPath

        {

            get; set;

        }
        public static void LaunchIE()


        {
            _ = Process.Start(GetIEPath);

        }
    }
} 

             