
namespace MDIProjektPrototyp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 822);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 822);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Friends";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 822);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Goals";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 822);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(button4_Click);



            
            // 
            // Form1
            // 
            InitializeUI();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 857);
            
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);

        }

        #endregion


        #region Code for Initializeing Basic UI

        private void InitializeUI()
        {
            this.button1.Show();
            this.button2.Show();
            this.button3.Show();
            this.button4.Show();
        }

        #endregion
        private void HideEverything()
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Hide();
            }
        }

        private void InitializeFriends()
        {
            HideEverything();
            InitializeUI();

        }

        private void InitializeGoals()
        {
            HideEverything(); 
            InitializeUI();
            
        }

        private void InitializeProfile()
        {
            HideEverything();
            InitializeUI();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

