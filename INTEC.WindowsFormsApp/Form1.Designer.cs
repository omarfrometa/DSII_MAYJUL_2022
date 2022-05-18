namespace INTEC.WindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.txtP3 = new System.Windows.Forms.TextBox();
            this.txtP4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtP1
            // 
            this.txtP1.BackColor = System.Drawing.SystemColors.Window;
            this.txtP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP1.Location = new System.Drawing.Point(89, 265);
            this.txtP1.Margin = new System.Windows.Forms.Padding(2);
            this.txtP1.Name = "txtP1";
            this.txtP1.ReadOnly = true;
            this.txtP1.Size = new System.Drawing.Size(72, 76);
            this.txtP1.TabIndex = 1;
            this.txtP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP2
            // 
            this.txtP2.BackColor = System.Drawing.SystemColors.Window;
            this.txtP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP2.Location = new System.Drawing.Point(314, 265);
            this.txtP2.Margin = new System.Windows.Forms.Padding(2);
            this.txtP2.Name = "txtP2";
            this.txtP2.ReadOnly = true;
            this.txtP2.Size = new System.Drawing.Size(72, 76);
            this.txtP2.TabIndex = 2;
            this.txtP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP3
            // 
            this.txtP3.BackColor = System.Drawing.SystemColors.Window;
            this.txtP3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP3.Location = new System.Drawing.Point(529, 269);
            this.txtP3.Margin = new System.Windows.Forms.Padding(2);
            this.txtP3.Name = "txtP3";
            this.txtP3.ReadOnly = true;
            this.txtP3.Size = new System.Drawing.Size(72, 76);
            this.txtP3.TabIndex = 3;
            this.txtP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP4
            // 
            this.txtP4.BackColor = System.Drawing.Color.Crimson;
            this.txtP4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP4.Location = new System.Drawing.Point(737, 269);
            this.txtP4.Margin = new System.Windows.Forms.Padding(2);
            this.txtP4.Name = "txtP4";
            this.txtP4.ReadOnly = true;
            this.txtP4.Size = new System.Drawing.Size(72, 76);
            this.txtP4.TabIndex = 4;
            this.txtP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::INTEC.WindowsFormsApp.Properties.Resources.lotery_results1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(898, 509);
            this.Controls.Add(this.txtP4);
            this.Controls.Add(this.txtP3);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.TextBox txtP3;
        private System.Windows.Forms.TextBox txtP4;
        private System.Windows.Forms.Timer timer1;
    }
}

