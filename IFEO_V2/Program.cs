/*
 * 2011/12/12   小改：
 * \r变为\r\n，使得notepad可以正确显示
 * 添加了args[i]: 这样的提示符
 * 修改了TargetTextPath，ExceptionPath。使用相对路径
 * 更改了\r\n的位置
*/
using System;
using System.Windows.Forms;
using System.IO;

namespace IFEO_V2
{
    static class Program
    {
        static string TargetTextPath = Path.GetTempPath() + "DOSSTONED_IFEO.txt";
        static string ExceptionPath = Path.GetTempPath() + "DOSSTONED_IFEO_Exception.txt";
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                try
                {
                    File.AppendAllText(TargetTextPath, DateTime.Now.ToLongDateString() + "\t" + DateTime.Now.ToLongTimeString() + "\r\n");
                    PlayExceptionSound();
                    for (int i = 0; i < args.Length; i++)
                    {
                        File.AppendAllText(TargetTextPath, "args[" + i.ToString() + "]: " + args[i]);
                        File.AppendAllText(TargetTextPath, "\r\n");
                    }
                    File.AppendAllText(TargetTextPath, "----------------------------------------------------\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

        static void PlayExceptionSound()
        {
            /*

            // Solution 1: Play the default sound
            System.Media.SystemSounds.Hand.Play();


            // Solution 2: Play the wav file (since the time is limited, the sound cannot be played fully out even loaded before)
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(TargetTransferredPath);
            snd.Load();
            snd.Play();
            
            
            // Solution 3: Use a deamon process to play the sound
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            try
            {
                proc.StartInfo = new System.Diagnostics.ProcessStartInfo("D:\\石道辰\\Programming\\传送门\\传送门\\bin\\Debug\\传送门.exe", "PLAYIFEOSOUND");
                proc.Start();
            }
            catch
            {
            }
            
            
            */



            // Solution 2: Play the wav file (since the time is limited, the sound cannot be played fully out even loaded before)
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(Properties.Resources.Alert_ProtossProtossWarpInComplete);
            //snd.Load();
            snd.Play();
            System.Threading.Thread.Sleep(3000);
        }
    }
}
