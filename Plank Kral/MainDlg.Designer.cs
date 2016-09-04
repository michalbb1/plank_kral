namespace Plank_Kral
{
    partial class MainDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_StartPlank = new System.Windows.Forms.Button();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.timer_plankingTime = new System.Windows.Forms.Timer(this.components);
            this.btn_Plus5 = new System.Windows.Forms.Button();
            this.btn_Minus5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Minus1 = new System.Windows.Forms.Button();
            this.btn_Plus1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_StartPlank
            // 
            this.btn_StartPlank.Location = new System.Drawing.Point(996, 681);
            this.btn_StartPlank.Name = "btn_StartPlank";
            this.btn_StartPlank.Size = new System.Drawing.Size(231, 89);
            this.btn_StartPlank.TabIndex = 0;
            this.btn_StartPlank.Text = "Start Plank";
            this.btn_StartPlank.UseVisualStyleBackColor = true;
            this.btn_StartPlank.Click += new System.EventHandler(this.btn_StartPlank_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.Location = new System.Drawing.Point(0, 274);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(1284, 108);
            this.lbl_Time.TabIndex = 1;
            this.lbl_Time.Text = "00:00:000";
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer_plankingTime
            // 
            this.timer_plankingTime.Tick += new System.EventHandler(this.timer_plankingTime_Tick);
            // 
            // btn_Plus5
            // 
            this.btn_Plus5.Location = new System.Drawing.Point(354, 88);
            this.btn_Plus5.Name = "btn_Plus5";
            this.btn_Plus5.Size = new System.Drawing.Size(68, 65);
            this.btn_Plus5.TabIndex = 2;
            this.btn_Plus5.Text = "+5";
            this.btn_Plus5.UseVisualStyleBackColor = true;
            this.btn_Plus5.Click += new System.EventHandler(this.btn_Plus5_Click);
            // 
            // btn_Minus5
            // 
            this.btn_Minus5.Location = new System.Drawing.Point(354, 19);
            this.btn_Minus5.Name = "btn_Minus5";
            this.btn_Minus5.Size = new System.Drawing.Size(68, 65);
            this.btn_Minus5.TabIndex = 3;
            this.btn_Minus5.Text = "-5";
            this.btn_Minus5.UseVisualStyleBackColor = true;
            this.btn_Minus5.Click += new System.EventHandler(this.btn_Minus5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Minus1);
            this.groupBox1.Controls.Add(this.btn_Plus1);
            this.groupBox1.Controls.Add(this.btn_Plus5);
            this.groupBox1.Controls.Add(this.btn_Minus5);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 159);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Time Control";
            // 
            // btn_Minus1
            // 
            this.btn_Minus1.Location = new System.Drawing.Point(280, 17);
            this.btn_Minus1.Name = "btn_Minus1";
            this.btn_Minus1.Size = new System.Drawing.Size(68, 65);
            this.btn_Minus1.TabIndex = 5;
            this.btn_Minus1.Text = "-1";
            this.btn_Minus1.UseVisualStyleBackColor = true;
            this.btn_Minus1.Click += new System.EventHandler(this.btn_Minus1_Click);
            // 
            // btn_Plus1
            // 
            this.btn_Plus1.Location = new System.Drawing.Point(280, 88);
            this.btn_Plus1.Name = "btn_Plus1";
            this.btn_Plus1.Size = new System.Drawing.Size(68, 65);
            this.btn_Plus1.TabIndex = 4;
            this.btn_Plus1.Text = "+1";
            this.btn_Plus1.UseVisualStyleBackColor = true;
            this.btn_Plus1.Click += new System.EventHandler(this.btn_Plus1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 329);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 91);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plank Kral v2.0";
            // 
            // MainDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 782);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_StartPlank);
            this.Name = "MainDlg";
            this.Text = "Plank Kral v2.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDlg_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartPlank;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer timer_plankingTime;
        private System.Windows.Forms.Button btn_Plus5;
        private System.Windows.Forms.Button btn_Minus5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Minus1;
        private System.Windows.Forms.Button btn_Plus1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

