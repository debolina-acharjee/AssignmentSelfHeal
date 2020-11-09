using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Data_IE
{
    class TempFile

    {

            public static void DeleteAppDataTemp()

            {

                string appDataTempPath = Path.GetTempPath();

                ulong accum = 0;



            Console.WriteLine("Deleting the file");

                Console.WriteLine(Environment.NewLine);

                ulong AppDataTempSizeDeleted = Application.EmptyFolder(appDataTempPath);

                accum += AppDataTempSizeDeleted;

                Console.WriteLine(Environment.NewLine);


            

            }

        }

    }

