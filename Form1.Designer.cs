
namespace HeadsOrTails
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picCoins = new PictureBox();
            btnShowHeads = new Button();
            btnShowTails = new Button();
            btnExit = new Button();
            btnFlip = new Button();
            labelHeads = new Label();
            labelTails = new Label();
            ((System.ComponentModel.ISupportInitialize)picCoins).BeginInit();
            SuspendLayout();
            // 
            // picCoins
            // 
            picCoins.Image = Properties.Resources.Heads2;
            picCoins.InitialImage = Properties.Resources.Tails2;
            picCoins.Location = new Point(303, 12);
            picCoins.Name = "picCoins";
            picCoins.Size = new Size(500, 500);
            picCoins.SizeMode = PictureBoxSizeMode.StretchImage;
            picCoins.TabIndex = 0;
            picCoins.TabStop = false;
//            picCoins.Click += picCoins_Click;
            // 
            // btnShowHeads
            // 
            btnShowHeads.BackColor = Color.Silver;
            btnShowHeads.Font = new Font("Bauhaus 93", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowHeads.Location = new Point(200, 572);
            btnShowHeads.Name = "btnShowHeads";
            btnShowHeads.Size = new Size(205, 49);
            btnShowHeads.TabIndex = 2;
            btnShowHeads.Text = "Show Heads";
            btnShowHeads.UseVisualStyleBackColor = false;
            btnShowHeads.Click += btnShowHeads_Click;
            // 
            // btnShowTails
            // 
            btnShowTails.BackColor = Color.Silver;
            btnShowTails.Font = new Font("Bauhaus 93", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowTails.ForeColor = Color.Black;
            btnShowTails.Location = new Point(440, 572);
            btnShowTails.Name = "btnShowTails";
            btnShowTails.Size = new Size(217, 49);
            btnShowTails.TabIndex = 3;
            btnShowTails.Text = "Show Tails";
            btnShowTails.UseVisualStyleBackColor = false;
            btnShowTails.Click += btnShowTails_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.Font = new Font("Bauhaus 93", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(691, 572);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(198, 49);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnFlip
            // 
            btnFlip.BackColor = Color.Silver;
            btnFlip.Font = new Font("Bauhaus 93", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFlip.Location = new Point(460, 687);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(197, 90);
            btnFlip.TabIndex = 5;
            btnFlip.Text = " COIN FLIP";
            btnFlip.UseVisualStyleBackColor = false;
            btnFlip.Click += btnFlip_Click;
            // 
            // labelHeads
            // 
            labelHeads.AutoSize = true;
            labelHeads.Location = new Point(90, 147);
            labelHeads.Name = "labelHeads";
            labelHeads.Size = new Size(101, 32);
            labelHeads.TabIndex = 6;
            labelHeads.Text = "Heads #";
            // 
            // labelTails
            // 
            labelTails.AutoSize = true;
            labelTails.Location = new Point(935, 147);
            labelTails.Name = "labelTails";
            labelTails.Size = new Size(79, 32);
            labelTails.TabIndex = 7;
            labelTails.Text = "Tails #";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1114, 865);
            Controls.Add(labelTails);
            Controls.Add(labelHeads);
            Controls.Add(btnFlip);
            Controls.Add(btnExit);
            Controls.Add(btnShowTails);
            Controls.Add(btnShowHeads);
            Controls.Add(picCoins);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)picCoins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCoins;
        private Button btnShowHeads;
        private Button btnShowTails;
        private Button btnExit;
        private Button btnFlip;
        private Label labelHeads;
        private Label labelTails;
        private TextBox headStat;
        private EventHandler headStat_TextChanged;
    }
}
