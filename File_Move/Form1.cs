using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using File_Move.Properties;
using System.Configuration;

namespace File_Move
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != System.Windows.Forms.CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                this.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            txtBK.Text = ConfigurationManager.AppSettings["strBK"];
            txtWatch.Text = ConfigurationManager.AppSettings["strWatch"];
            txtWatchSec.Text = ConfigurationManager.AppSettings["strWatchSec"];
            txtCopy.Text = ConfigurationManager.AppSettings["strCopy"];
            txtFilter.Text = ConfigurationManager.AppSettings["strFilter"];
            chkDelete.Checked = bool.Parse(ConfigurationManager.AppSettings["chkDelete"]);

            if (int.TryParse(txtWatchSec.Text,out int intSec))
            {
                timeWatcher.Interval = intSec * 1000;   //監視間隔を設定
            }
            int flgStart = 0;
            //フォルダが存在しない限りスタートしない
            if (FuncExists(txtWatch.Text)) flgStart++;
            if (FuncExists(txtCopy.Text) || FuncExists(txtBK.Text)) flgStart++;
            if (flgStart >= 2)
            {
                timeWatcher.Enabled = true;
                timeWatcher.Start();
                lblState.Text = "監視中";
            }
            else
            {
                MessageBox.Show("監視フォルダ、もしくはコピー先(BK)フォルダが指定されていません");
            }
            this.Visible = false;
        }

        private void btnWatchStart_Click(object sender, EventArgs e)
        {
            int flgStart = 0;
            //フォルダが存在しない限りスタートしない
            if (FuncExists(txtWatch.Text)) flgStart++;
            if (FuncExists(txtCopy.Text)||FuncExists(txtBK.Text)) flgStart++;
            if (int.TryParse(txtWatchSec.Text, out int intSec))
            {
                timeWatcher.Interval = intSec * 1000;   //監視間隔を設定
            }
            else
            {
                MessageBox.Show("監視間隔が指定されていません");
                return;
            }
            if (flgStart >= 2)
            {

                timeWatcher.Enabled = true;
                timeWatcher.Start();
                lblState.Text = "監視中";
            }
            else
            {
                MessageBox.Show("監視フォルダ、もしくはコピー先(BK)フォルダが指定されていません");
                return;
            }
            
        }

        private void timeWatcher_Tick(object sender, EventArgs e)
        {
            //監視対象フォルダ内のファイルを確認して存在していればコピーフォルダにコピーする
            string[] strFile;
            bool flgCopy = false;
            if (FuncExists(txtWatch.Text))
            {
                strFile = Directory.GetFiles(txtWatch.Text);
                for (int i = 0; i<strFile.Length; i++)
                {
                    if (strFile[i].Contains(txtFilter.Text))
                    {
                        //ファイルをコピーする
                        if (FuncExists(txtCopy.Text))
                        {
                            File.Copy(strFile[i], txtCopy.Text + @"\" + Path.GetFileName(strFile[i]), true);
                            flgCopy = true;
                        }
                        if (FuncExists(txtBK.Text))
                        {
                            File.Copy(strFile[i], txtBK.Text + @"\" + Path.GetFileName(strFile[i]), true);
                            flgCopy = true;
                        }
                        //コピーできたら元ファイル削除を起動
                        if (flgCopy && chkDelete.Checked) File.Delete(strFile[i]);
                        flgCopy = false;
                    }
                }
            }
        }

        public bool FuncExists(string strPath, int i_wait = 150)     //i_wait[ms]だけ処理待ちさせる
        {
            bool exists = true;
            if (strPath == "") return false;
            string strTmp = strPath;
            if (strPath.Substring(strPath.Length - 1) == @"\")
                strTmp = Path.GetDirectoryName(strPath);

            Thread t = new Thread
            (
                new ThreadStart(delegate ()
                {
                    if (Path.GetFileName(strTmp).Contains("."))
                        exists = File.Exists(strTmp);
                    else
                        exists = Directory.Exists(strTmp);
                })
             );
            t.Start();
            bool completed = t.Join(i_wait);
            if (!completed)
            {
                //if (exists) MessageBox.Show("存在していると認識されている");
                exists = false;
                t.Abort();
            }
            return exists;
        }

        private void btnWatchEnd_Click(object sender, EventArgs e)
        {
            timeWatcher.Stop();
            timeWatcher.Enabled = false;
            lblState.Text = "監視停止";
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["strBK"].Value = txtBK.Text;
            config.AppSettings.Settings["strWatch"].Value = txtWatch.Text;
            config.AppSettings.Settings["strWatchSec"].Value = txtWatchSec.Text;
            config.AppSettings.Settings["strCopy"].Value = txtCopy.Text;
            config.AppSettings.Settings["strFilter"].Value = txtFilter.Text;
            config.AppSettings.Settings["chkDelete"].Value = chkDelete.Checked.ToString();
            config.Save();
        }
    }
}
