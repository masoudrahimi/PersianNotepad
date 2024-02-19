namespace PersianNotepad
{
    partial class frmSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbContain = new System.Windows.Forms.RadioButton();
            this.rdbExactly = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDown = new System.Windows.Forms.RadioButton();
            this.rdbUp = new System.Windows.Forms.RadioButton();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(116, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(304, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "لغو";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbContain);
            this.groupBox1.Controls.Add(this.rdbExactly);
            this.groupBox1.Location = new System.Drawing.Point(274, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نحوه جستجو";
            // 
            // rdbContain
            // 
            this.rdbContain.AutoSize = true;
            this.rdbContain.Checked = true;
            this.rdbContain.Location = new System.Drawing.Point(61, 45);
            this.rdbContain.Name = "rdbContain";
            this.rdbContain.Size = new System.Drawing.Size(133, 18);
            this.rdbContain.TabIndex = 4;
            this.rdbContain.TabStop = true;
            this.rdbContain.Text = "شامل این کلمه باشد";
            this.rdbContain.UseVisualStyleBackColor = true;
            // 
            // rdbExactly
            // 
            this.rdbExactly.AutoSize = true;
            this.rdbExactly.Location = new System.Drawing.Point(84, 21);
            this.rdbExactly.Name = "rdbExactly";
            this.rdbExactly.Size = new System.Drawing.Size(110, 18);
            this.rdbExactly.TabIndex = 3;
            this.rdbExactly.Text = "دقیقاً همین کلمه";
            this.rdbExactly.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbDown);
            this.groupBox2.Controls.Add(this.rdbUp);
            this.groupBox2.Location = new System.Drawing.Point(116, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 73);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جهت جستجو";
            // 
            // rdbDown
            // 
            this.rdbDown.AutoSize = true;
            this.rdbDown.Checked = true;
            this.rdbDown.Location = new System.Drawing.Point(15, 34);
            this.rdbDown.Name = "rdbDown";
            this.rdbDown.Size = new System.Drawing.Size(48, 18);
            this.rdbDown.TabIndex = 4;
            this.rdbDown.TabStop = true;
            this.rdbDown.Text = "پایین";
            this.rdbDown.UseVisualStyleBackColor = true;
            // 
            // rdbUp
            // 
            this.rdbUp.AutoSize = true;
            this.rdbUp.Location = new System.Drawing.Point(92, 34);
            this.rdbUp.Name = "rdbUp";
            this.rdbUp.Size = new System.Drawing.Size(39, 18);
            this.rdbUp.TabIndex = 3;
            this.rdbUp.Text = "بالا";
            this.rdbUp.UseVisualStyleBackColor = true;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(116, 48);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(304, 22);
            this.txtReplace.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "جایگزینی";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(12, 47);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(87, 23);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "جایگزینی";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(12, 75);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(87, 23);
            this.btnReplaceAll.TabIndex = 9;
            this.btnReplaceAll.Text = "جایگزینی همه";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 157);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSearch";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جستجو";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSearch_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbContain;
        private System.Windows.Forms.RadioButton rdbExactly;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbDown;
        private System.Windows.Forms.RadioButton rdbUp;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}