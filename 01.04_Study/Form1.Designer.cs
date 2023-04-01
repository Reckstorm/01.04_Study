using System.Drawing;
using System.Windows.Forms;

namespace _01._04_Study
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            int i = 1;

            btn.Click += (e, s) =>
            {
                if (i == 1)
                {
                    this.BackColor = Color.Red;
                    i++;
                }
                if (i == 2)
                {
                    this.BackColor = Color.Yellow;
                    i++;
                }
                else
                {
                    this.BackColor = Color.Green;
                    i = 1;
                }
            };
            this.Contains(btn);
            }
            Button btn;
        #endregion
    }
}

