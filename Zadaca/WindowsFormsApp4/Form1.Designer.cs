namespace WindowsFormsApp4
{
    partial class Form1
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
            this.year2 = new System.Windows.Forms.RadioButton();
            this.year3 = new System.Windows.Forms.RadioButton();
            this.year1 = new System.Windows.Forms.RadioButton();
            this.year4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.platform1 = new System.Windows.Forms.CheckBox();
            this.platform2 = new System.Windows.Forms.CheckBox();
            this.platform3 = new System.Windows.Forms.CheckBox();
            this.platform4 = new System.Windows.Forms.CheckBox();
            this.platform5 = new System.Windows.Forms.CheckBox();
            this.platform6 = new System.Windows.Forms.CheckBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // year2
            // 
            this.year2.AutoSize = true;
            this.year2.Location = new System.Drawing.Point(84, 65);
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(90, 17);
            this.year2.TabIndex = 0;
            this.year2.TabStop = true;
            this.year2.Text = "1 do 3 godina";
            this.year2.UseVisualStyleBackColor = true;
            this.year2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // year3
            // 
            this.year3.AutoSize = true;
            this.year3.Location = new System.Drawing.Point(84, 109);
            this.year3.Name = "year3";
            this.year3.Size = new System.Drawing.Size(90, 17);
            this.year3.TabIndex = 1;
            this.year3.TabStop = true;
            this.year3.Text = "3 do 5 godina";
            this.year3.UseVisualStyleBackColor = true;
            this.year3.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // year1
            // 
            this.year1.AutoSize = true;
            this.year1.Location = new System.Drawing.Point(84, 41);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(72, 17);
            this.year1.TabIndex = 2;
            this.year1.TabStop = true;
            this.year1.Text = "<1 godina";
            this.year1.UseVisualStyleBackColor = true;
            this.year1.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // year4
            // 
            this.year4.AutoSize = true;
            this.year4.Location = new System.Drawing.Point(84, 87);
            this.year4.Name = "year4";
            this.year4.Size = new System.Drawing.Size(72, 17);
            this.year4.TabIndex = 3;
            this.year4.TabStop = true;
            this.year4.Text = ">5 godina";
            this.year4.UseVisualStyleBackColor = true;
            this.year4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = " platforme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Godine iskustva ";
            // 
            // platform1
            // 
            this.platform1.AutoSize = true;
            this.platform1.Location = new System.Drawing.Point(12, 42);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(52, 17);
            this.platform1.TabIndex = 6;
            this.platform1.Text = "Java ";
            this.platform1.UseVisualStyleBackColor = true;
            this.platform1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // platform2
            // 
            this.platform2.AutoSize = true;
            this.platform2.Location = new System.Drawing.Point(12, 65);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(47, 17);
            this.platform2.TabIndex = 7;
            this.platform2.Text = "IOS ";
            this.platform2.UseVisualStyleBackColor = true;
            this.platform2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // platform3
            // 
            this.platform3.AutoSize = true;
            this.platform3.Location = new System.Drawing.Point(12, 87);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(50, 17);
            this.platform3.TabIndex = 8;
            this.platform3.Text = "SQL ";
            this.platform3.UseVisualStyleBackColor = true;
            this.platform3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // platform4
            // 
            this.platform4.AutoSize = true;
            this.platform4.Location = new System.Drawing.Point(12, 110);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(65, 17);
            this.platform4.TabIndex = 9;
            this.platform4.Text = "Android ";
            this.platform4.UseVisualStyleBackColor = true;
            this.platform4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // platform5
            // 
            this.platform5.AutoSize = true;
            this.platform5.Location = new System.Drawing.Point(12, 133);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(49, 17);
            this.platform5.TabIndex = 10;
            this.platform5.Text = ".Net ";
            this.platform5.UseVisualStyleBackColor = true;
            this.platform5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // platform6
            // 
            this.platform6.AutoSize = true;
            this.platform6.Location = new System.Drawing.Point(12, 156);
            this.platform6.Name = "platform6";
            this.platform6.Size = new System.Drawing.Size(62, 17);
            this.platform6.TabIndex = 11;
            this.platform6.Text = "Python ";
            this.platform6.UseVisualStyleBackColor = true;
            this.platform6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(80, 132);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(87, 40);
            this.btn_send.TabIndex = 12;
            this.btn_send.Text = "Pošalji";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 181);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.platform6);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year4);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.year3);
            this.Controls.Add(this.year2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton year2;
        private System.Windows.Forms.RadioButton year3;
        private System.Windows.Forms.RadioButton year1;
        private System.Windows.Forms.RadioButton year4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox platform1;
        private System.Windows.Forms.CheckBox platform2;
        private System.Windows.Forms.CheckBox platform3;
        private System.Windows.Forms.CheckBox platform4;
        private System.Windows.Forms.CheckBox platform5;
        private System.Windows.Forms.CheckBox platform6;
        private System.Windows.Forms.Button btn_send;
    }
}

