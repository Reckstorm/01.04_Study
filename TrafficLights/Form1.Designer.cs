namespace TrafficLights
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            int i = 1;

              btn.Click(e, s) =>
            {
                switch (i)
                {
                    case 1:
                        this.BackColor = Color.Red;
                        iter++;
                    break;
                    case 2:
                        this.BackColor = Color.Yellow;
                        iter++;
                    break;
                    case 3:
                        this.BackColor = Color.Green;
                        iter = 1;
                    break;
                }
            }

            this.Controls.Add(btn);
        }

        Button btn;
        #endregion
    }
}