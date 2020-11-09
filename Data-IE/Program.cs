using System.Diagnostics;
using System;


namespace Data_IE
{
    class Program
    {


        static void Main(string[] args)
        {
            try

            {
                #region LaunchingIE

                Application.LaunchIE();

                #endregion

                #region Clear Windows Temp Files

                TempFile.DeleteAppDataTemp();

                Console.WriteLine("Deleting the file");

                #endregion

                #region Clear IE Cache
                Console.WriteLine("Clearing the TempFiles");
                ClearIE.ExecuteClearIECache("TempFiles");
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred" + ex);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

