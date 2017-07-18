/*
 * 修改历史:
 * BugFix1:
 *  20100802 遇到删除某一项之后，再点击listBoxContent会出现错误，应为SelectItem为null导致，错误位置为原来49行，现50行
 *  解决方案：添加现在的第49行，进行错误检查
 *  
 * 功能添加：
 *  如果当前输入的程序没有指定Image Path，那么使用该程序的Path.
 *  
 * BugFix2:
 *  2011/12/12  如果没有指定程序名，那么依然会添加，直接添加到IFEO那个目录项里边了
 *  解决方案：如果textBoxName什么都没填，那么什么都不干
 *  
 * BugFix3:
 *  2012/02/01  如果选则了一项，但是不是管理员，那么取消之后会报错
 *  解决方案：在程序加载的时候检测，如果不是admin，那么就隐藏buttonDel，并且textBox变为Disabled
 *  并且在两个button的检测admin变为if-else。而不是单个的if
*/



using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace IFEO_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetIFEOData(sender, e);
        }




        private void GetIFEOData(object sender, EventArgs e)
        {
            listBoxContent.Items.Clear();
            RegistryKey IFEOReg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options");

            if (IFEOReg != null)
            {
                foreach (string IFEOKey in IFEOReg.GetSubKeyNames())
                {
                    RegistryKey CurIFEOKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\" + IFEOKey);
                    if (CurIFEOKey.GetValue("debugger", null) != null)
                    {
                        listBoxContent.Items.Add(IFEOKey);
                    }
                }
            }
            IFEOReg.Close();
        }

        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContent.SelectedItem != null)
                textBoxName.Text = listBoxContent.SelectedItem.ToString();
            else
            {
                textBoxName.Text = string.Empty;
                textBoxImage.Text = string.Empty;
                return;
            }
            RegistryKey SelectIFEOKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\" + textBoxName.Text);
            if (SelectIFEOKey.GetValue("Debugger", null) != null)
            {
                textBoxImage.Text = SelectIFEOKey.GetValue("debugger", null).ToString();
            }
            SelectIFEOKey.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {

            if (!ClassWin6Privileges.IsAdmin())
                ClassWin6Privileges.RestartElevated();
            else
            {
                if (textBoxName.Text == string.Empty) return;
                RegistryKey SelectIFEOKey = null;
                try
                {
                    string ImagePath = textBoxImage.Text;
                    if (ImagePath == string.Empty)
                    {
                        ImagePath = Application.ExecutablePath;
                    }
                    SelectIFEOKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\" + textBoxName.Text);
                    SelectIFEOKey.SetValue("Debugger", ImagePath, RegistryValueKind.String);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (SelectIFEOKey != null)
                        SelectIFEOKey.Close();
                }
                GetIFEOData(sender, e);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (!ClassWin6Privileges.IsAdmin())
                ClassWin6Privileges.RestartElevated();
            else
            {
                if (textBoxName.Text == string.Empty) return;
                RegistryKey SelectIFEOKey = null;
                try
                {
                    SelectIFEOKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\" + textBoxName.Text);
                    SelectIFEOKey.DeleteValue("Debugger", false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (SelectIFEOKey != null)
                        SelectIFEOKey.Close();
                }
                GetIFEOData(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetIFEOData(sender, e);
            if (!ClassWin6Privileges.IsAdmin())
            {
                ClassWin6Privileges.VistaSecurity.AddShieldToButton(buttonApply);
                ClassWin6Privileges.VistaSecurity.AddShieldToButton(buttonDel);
                textBoxImage.Enabled = false;
                textBoxName.Enabled = false;
                buttonDel.Visible = false;
                buttonApply.Text = "Run as admin";
            }
        }

    }
}
