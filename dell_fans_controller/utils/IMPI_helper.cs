using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dell_fans_controller.utils
{
   public static class IMPI_helper
    {
        public static string execute(string parameter)
        {
            Process process = null;
            string result = string.Empty;
            try
            {
                process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;

                process.Start();

                process.StandardInput.WriteLine(parameter + "& exit");
                process.StandardInput.AutoFlush = true;
                result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                process.Close();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExceptionOccurred:{ 0},{ 1}", ex.Message, ex.StackTrace.ToString());
                return null;
            }
        }      

        public static async Task<string> GetStatus(string args)
        {
            Process process = null;
            string result = string.Empty;
            Task<string> task = Task.Run<string>(() =>
            {
                process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();
                process.StandardInput.WriteLine(args + "& exit");
                process.StandardInput.AutoFlush = true;
                result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                process.Close();
                return result;

            });

            try
            {
                string res = await task;
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ExceptionOccurred:{ 0},{ 1}", ex.Message, ex.StackTrace.ToString());
                return null;
            }
        }
    }
}
