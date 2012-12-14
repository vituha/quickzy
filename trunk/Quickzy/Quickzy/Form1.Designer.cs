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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCorrectAnswers = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalAnswers = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbFolder = new System.Windows.Forms.ComboBox();
            this.bAnswer3 = new System.Windows.Forms.Button();
            this.bAnswer2 = new System.Windows.Forms.Button();
            this.bAnswer1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultCorrect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultTotal = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.pnlQuestions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlResults.SuspendLayout();
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
            this.lblTotalAnswers.Text = "0";
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.Controls.Add(this.panel1);
            this.pnlQuestions.Controls.Add(this.panel2);
            this.pnlQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestions.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(857, 440);
            this.pnlQuestions.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(500, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 440);
            this.panel1.TabIndex = 4;
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
            this.panel2.TabIndex = 5;
            // 
            // cbFolder
            // 
            this.cbFolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFolder.Location = new System.Drawing.Point(0, 0);
            this.cbFolder.Name = "cbFolder";
            this.cbFolder.Size = new System.Drawing.Size(198, 21);
            this.cbFolder.TabIndex = 10;
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
            this.bAnswer3.Click += new System.EventHandler(this.bAnswer3_Click);
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
            this.bAnswer2.Click += new System.EventHandler(this.bAnswer2_Click);
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
            this.bAnswer1.Click += new System.EventHandler(this.bAnswer1_Click);
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
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.lblResultTotal);
            this.pnlResults.Controls.Add(this.label4);
            this.pnlResults.Controls.Add(this.lblResultCorrect);
            this.pnlResults.Controls.Add(this.label2);
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.Location = new System.Drawing.Point(0, 0);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(857, 440);
            this.pnlResults.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ваш pезультат";
            // 
            // lblResultCorrect
            // 
            this.lblResultCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultCorrect.AutoSize = true;
            this.lblResultCorrect.Location = new System.Drawing.Point(369, 167);
            this.lblResultCorrect.Name = "lblResultCorrect";
            this.lblResultCorrect.Size = new System.Drawing.Size(59, 13);
            this.lblResultCorrect.TabIndex = 1;
            this.lblResultCorrect.Text = "CORRECT";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "правильных из";
            // 
            // lblResultTotal
            // 
            this.lblResultTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultTotal.AutoSize = true;
            this.lblResultTotal.Location = new System.Drawing.Point(523, 167);
            this.lblResultTotal.Name = "lblResultTotal";
            this.lblResultTotal.Size = new System.Drawing.Size(42, 13);
            this.lblResultTotal.TabIndex = 3;
            this.lblResultTotal.Text = "TOTAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 462);
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Quickzy ;)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlQuestions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.pnlResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCorrectAnswers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalAnswers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbFolder;
        private System.Windows.Forms.Button bAnswer3;
        private System.Windows.Forms.Button bAnswer2;
        private System.Windows.Forms.Button bAnswer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Label lblResultTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultCorrect;
        private System.Windows.Forms.Label label2;

    }
}

