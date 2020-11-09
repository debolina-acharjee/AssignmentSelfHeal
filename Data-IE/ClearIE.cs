using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_IE
{
    class ClearIE
    {
        public static void ExecuteClearIECache(string clearType)

        {

            try

            {

                switch (clearType)

                {

                    case "TempFiles":

                        //Temporary Internet Files

                        var temp = System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8200");

                        while (!temp.HasExited)

                        {



                        }

                        break;

                    case "Cookies":

                        var cook = System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8194");

                        while (!cook.HasExited)
                        {



                        }


                        break;
                    default:

                        Console.WriteLine("The cache and cookies are clear");

                        Console.ReadLine();

                        break;
                }
            }


            catch (Exception ex)

            {

                Console.Write(ex.StackTrace);

                Console.ReadLine();

            }
        }
    }
}
