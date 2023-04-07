namespace TrafficLights
{
    public partial class Form1 : Form
    {
        bool player = true; //true- first player,  false - second player
        List<Button> buttonList = new List<Button>();

        private bool WinCheck(string symbolCheck)
        {
            if (((buttonList[0].Text.Equals(symbolCheck) && buttonList[3].Text.Equals(symbolCheck) && buttonList[6].Text.Equals(symbolCheck)) ||
               (buttonList[1].Text.Equals(symbolCheck) && buttonList[4].Text.Equals(symbolCheck) && buttonList[7].Text.Equals(symbolCheck)) ||
               (buttonList[2].Text.Equals(symbolCheck) && buttonList[5].Text.Equals(symbolCheck) && buttonList[8].Text.Equals(symbolCheck)) ||
               (buttonList[0].Text.Equals(symbolCheck) && buttonList[1].Text.Equals(symbolCheck) && buttonList[2].Text.Equals(symbolCheck)) ||
               (buttonList[3].Text.Equals(symbolCheck) && buttonList[4].Text.Equals(symbolCheck) && buttonList[5].Text.Equals(symbolCheck)) ||
               (buttonList[6].Text.Equals(symbolCheck) && buttonList[7].Text.Equals(symbolCheck) && buttonList[8].Text.Equals(symbolCheck)) ||
               (buttonList[0].Text.Equals(symbolCheck) && buttonList[4].Text.Equals(symbolCheck) && buttonList[8].Text.Equals(symbolCheck)) ||
               (buttonList[2].Text.Equals(symbolCheck) && buttonList[4].Text.Equals(symbolCheck) && buttonList[6].Text.Equals(symbolCheck))))
                return true;
            else
                return false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            //the game buttons

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Button button = new Button();
                    button.Size = new Size(100, 100);
                    button.Location = new Point(col * 100, row * 100);
                    buttonList.Add(button);
                }
            }

            foreach (Button btn in buttonList)
            {
                btn.Click += (e, sender) =>
                {
                    btn.Font = new Font("Times New Roman", 35, FontStyle.Bold);
                    if (player)
                    {
                        btn.Text = "X";
                        btn.BackColor = Color.Green;
                        btn.Enabled = false;
                        if (WinCheck("X"))
                        {
                            this.Text = "The first player wins! Game over!";
                            foreach (Button btn2 in buttonList)
                            {
                                btn2.Enabled = false;
                            }
                        }
                    }
                    else
                    {
                        btn.Text = "0";
                        btn.BackColor = Color.Yellow;
                        btn.Enabled = false;
                        if (WinCheck("0"))
                        {
                            this.Text = "The second player wins! Game over!";
                            foreach (Button btn2 in buttonList)
                            {
                                btn2.Enabled = false;
                            }
                        }
                    }
                    player = !player;
                };
                Controls.Add(btn);
            }
        }


        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }
    }
}
