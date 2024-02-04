namespace File_Move
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.閉じるToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWatchSec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWatchStart = new System.Windows.Forms.Button();
            this.btnWatchEnd = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timeWatcher = new System.Windows.Forms.Timer(this.components);
            this.btnSetting = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "File_Move";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.閉じるToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 48);
            this.contextMenuStrip1.UseWaitCursor = true;
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.開くToolStripMenuItem_Click);
            // 
            // 閉じるToolStripMenuItem
            // 
            this.閉じるToolStripMenuItem.Name = "閉じるToolStripMenuItem";
            this.閉じるToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.閉じるToolStripMenuItem.Text = "閉じる";
            this.閉じるToolStripMenuItem.Click += new System.EventHandler(this.閉じるToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "検知フォルダ：";
            // 
            // txtWatch
            // 
            this.txtWatch.Location = new System.Drawing.Point(83, 47);
            this.txtWatch.Name = "txtWatch";
            this.txtWatch.Size = new System.Drawing.Size(705, 19);
            this.txtWatch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "コピー先フォルダ：";
            // 
            // txtCopy
            // 
            this.txtCopy.Location = new System.Drawing.Point(84, 198);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(705, 19);
            this.txtCopy.TabIndex = 2;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkDelete.Location = new System.Drawing.Point(639, 18);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(139, 23);
            this.chkDelete.TabIndex = 3;
            this.chkDelete.Text = "元ファイル削除";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "バックアップ先フォルダ：";
            // 
            // txtBK
            // 
            this.txtBK.Location = new System.Drawing.Point(84, 246);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(705, 19);
            this.txtBK.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "監視間隔：";
            // 
            // txtWatchSec
            // 
            this.txtWatchSec.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtWatchSec.Location = new System.Drawing.Point(112, 71);
            this.txtWatchSec.Name = "txtWatchSec";
            this.txtWatchSec.Size = new System.Drawing.Size(96, 26);
            this.txtWatchSec.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "秒(30秒以上)　※監視時間を変えたら監視終了⇒開始開始と再起動しないと反映されません。";
            // 
            // btnWatchStart
            // 
            this.btnWatchStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWatchStart.Location = new System.Drawing.Point(536, 271);
            this.btnWatchStart.Name = "btnWatchStart";
            this.btnWatchStart.Size = new System.Drawing.Size(123, 39);
            this.btnWatchStart.TabIndex = 4;
            this.btnWatchStart.Text = "監視開始";
            this.btnWatchStart.UseVisualStyleBackColor = true;
            this.btnWatchStart.Click += new System.EventHandler(this.btnWatchStart_Click);
            // 
            // btnWatchEnd
            // 
            this.btnWatchEnd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnWatchEnd.Location = new System.Drawing.Point(665, 271);
            this.btnWatchEnd.Name = "btnWatchEnd";
            this.btnWatchEnd.Size = new System.Drawing.Size(123, 39);
            this.btnWatchEnd.TabIndex = 4;
            this.btnWatchEnd.Text = "監視終了";
            this.btnWatchEnd.UseVisualStyleBackColor = true;
            this.btnWatchEnd.Click += new System.EventHandler(this.btnWatchEnd_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(436, 282);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(75, 16);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "監視停止";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "監視ファイル種類：";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtFilter.Location = new System.Drawing.Point(111, 106);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(213, 26);
            this.txtFilter.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "を含む(後方一致)";
            // 
            // timeWatcher
            // 
            this.timeWatcher.Tick += new System.EventHandler(this.timeWatcher_Tick);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSetting.Location = new System.Drawing.Point(21, 271);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(123, 39);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "設定保存";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 322);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnWatchEnd);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnWatchStart);
            this.Controls.Add(this.chkDelete);
            this.Controls.Add(this.txtBK);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtWatchSec);
            this.Controls.Add(this.txtWatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FileMove";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 閉じるToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCopy;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWatchSec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWatchStart;
        private System.Windows.Forms.Button btnWatchEnd;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timeWatcher;
        private System.Windows.Forms.Button btnSetting;
    }
}

