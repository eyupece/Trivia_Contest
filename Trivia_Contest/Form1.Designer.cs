namespace Trivia_Contest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttona = new System.Windows.Forms.Button();
            this.buttonb = new System.Windows.Forms.Button();
            this.buttond = new System.Windows.Forms.Button();
            this.buttonc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelqno = new System.Windows.Forms.Label();
            this.labelcorrect = new System.Windows.Forms.Label();
            this.labelwrong = new System.Windows.Forms.Label();
            this.buttonnext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(483, 174);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttona
            // 
            this.buttona.Location = new System.Drawing.Point(12, 192);
            this.buttona.Name = "buttona";
            this.buttona.Size = new System.Drawing.Size(226, 43);
            this.buttona.TabIndex = 1;
            this.buttona.Text = "A";
            this.buttona.UseVisualStyleBackColor = true;
            this.buttona.Click += new System.EventHandler(this.buttona_Click);
            // 
            // buttonb
            // 
            this.buttonb.Location = new System.Drawing.Point(244, 192);
            this.buttonb.Name = "buttonb";
            this.buttonb.Size = new System.Drawing.Size(251, 43);
            this.buttonb.TabIndex = 2;
            this.buttonb.Text = "B";
            this.buttonb.UseVisualStyleBackColor = true;
            this.buttonb.Click += new System.EventHandler(this.buttonb_Click);
            // 
            // buttond
            // 
            this.buttond.Location = new System.Drawing.Point(244, 241);
            this.buttond.Name = "buttond";
            this.buttond.Size = new System.Drawing.Size(251, 43);
            this.buttond.TabIndex = 4;
            this.buttond.Text = "D";
            this.buttond.UseVisualStyleBackColor = true;
            this.buttond.Click += new System.EventHandler(this.buttond_Click);
            // 
            // buttonc
            // 
            this.buttonc.Location = new System.Drawing.Point(12, 241);
            this.buttonc.Name = "buttonc";
            this.buttonc.Size = new System.Drawing.Size(226, 43);
            this.buttonc.TabIndex = 3;
            this.buttonc.Text = "C";
            this.buttonc.UseVisualStyleBackColor = true;
            this.buttonc.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Q NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "CORRECT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "WRONG";
            // 
            // labelqno
            // 
            this.labelqno.AutoSize = true;
            this.labelqno.Location = new System.Drawing.Point(642, 40);
            this.labelqno.Name = "labelqno";
            this.labelqno.Size = new System.Drawing.Size(24, 28);
            this.labelqno.TabIndex = 8;
            this.labelqno.Text = "0";
            // 
            // labelcorrect
            // 
            this.labelcorrect.AutoSize = true;
            this.labelcorrect.Location = new System.Drawing.Point(642, 77);
            this.labelcorrect.Name = "labelcorrect";
            this.labelcorrect.Size = new System.Drawing.Size(24, 28);
            this.labelcorrect.TabIndex = 9;
            this.labelcorrect.Text = "0";
            this.labelcorrect.Click += new System.EventHandler(this.labelcorrect_Click);
            // 
            // labelwrong
            // 
            this.labelwrong.AutoSize = true;
            this.labelwrong.Location = new System.Drawing.Point(642, 118);
            this.labelwrong.Name = "labelwrong";
            this.labelwrong.Size = new System.Drawing.Size(24, 28);
            this.labelwrong.TabIndex = 10;
            this.labelwrong.Text = "0";
            // 
            // buttonnext
            // 
            this.buttonnext.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonnext.Location = new System.Drawing.Point(524, 149);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(165, 43);
            this.buttonnext.TabIndex = 11;
            this.buttonnext.Text = "NEXT QUESTİON";
            this.buttonnext.UseVisualStyleBackColor = true;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(733, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(733, 118);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(884, 396);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.labelwrong);
            this.Controls.Add(this.labelcorrect);
            this.Controls.Add(this.labelqno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttond);
            this.Controls.Add(this.buttonc);
            this.Controls.Add(this.buttonb);
            this.Controls.Add(this.buttona);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttona;
        private System.Windows.Forms.Button buttonb;
        private System.Windows.Forms.Button buttond;
        private System.Windows.Forms.Button buttonc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelqno;
        private System.Windows.Forms.Label labelcorrect;
        private System.Windows.Forms.Label labelwrong;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

