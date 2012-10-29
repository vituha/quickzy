namespace Quickzy
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCorrectAnswers = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalAnswers = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFolder = new System.Windows.Forms.ComboBox();
            this.bAnswer3 = new System.Windows.Forms.Button();
            this.bAnswer2 = new System.Windows.Forms.Button();
            this.bAnswer1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCorrectAnswers,
            this.toolStripStatusLabel2,
            this.lblTotalAnswers});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Text = "Correct answers:";
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(13, 17);
            this.lblCorrectAnswers.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel2.Text = "of";
            // 
            // lblTotalAnswers
            // 
            this.lblTotalAnswers.Name = "lblTotalAnswers";
            this.lblTotalAnswers.Size = new System.Drawing.Size(13, 17);
            this.lblTotalAnswers.Text = "1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbFolder);
            this.panel2.Controls.Add(this.bAnswer3);
            this.panel2.Controls.Add(this.bAnswer2);
            this.panel2.Controls.Add(this.bAnswer1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(657, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(200, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 440);
            this.panel2.TabIndex = 2;
            // 
            // cbFolder
            // 
            this.cbFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFolder.Location = new System.Drawing.Point(0, 0);
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Size = new System.Drawing.Size(198, 21);
            this.cbFolder.TabIndex = 10;
            this.cbFolder.SelectedValueChanged += new System.EventHandler(this.cbFolder_SelectedValueChanged);
            // 
            // bAnswer3
            // 
            this.bAnswer3.Location = new System.Drawing.Point(28, 154);
            this.bAnswer3.Name = "bAnswer3";
            this.bAnswer3.Size = new System.Drawing.Size(138, 25);
            this.bAnswer3.TabIndex = 9;
            this.bAnswer3.TabStop = false;
            this.bAnswer3.Text = "TV";
            this.bAnswer3.UseVisualStyleBackColor = true;
            // 
            // bAnswer2
            // 
            this.bAnswer2.Location = new System.Drawing.Point(28, 123);
            this.bAnswer2.Name = "bAnswer2";
            this.bAnswer2.Size = new System.Drawing.Size(138, 25);
            this.bAnswer2.TabIndex = 8;
            this.bAnswer2.TabStop = false;
            this.bAnswer2.Text = "Printer";
            this.bAnswer2.UseVisualStyleBackColor = true;
            // 
            // bAnswer1
            // 
            this.bAnswer1.Location = new System.Drawing.Point(28, 92);
            this.bAnswer1.Name = "bAnswer1";
            this.bAnswer1.Size = new System.Drawing.Size(138, 25);
            this.bAnswer1.TabIndex = 7;
            this.bAnswer1.TabStop = false;
            this.bAnswer1.Text = "Computer";
            this.bAnswer1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose correct answer:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 440);
            this.panel1.TabIndex = 3;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.ImageLocation = "http://cdn4.techpp.com/wp-content/uploads/2012/07/tv.jpg";
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.MinimumSize = new System.Drawing.Size(500, 300);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(657, 440);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Quickzy ;)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCorrectAnswers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalAnswers;
        private System.Windows.Forms.Button bAnswer3;
        private System.Windows.Forms.Button bAnswer2;
        private System.Windows.Forms.Button bAnswer1;
        private System.Windows.Forms.ComboBox cbFolder;

    }
}

