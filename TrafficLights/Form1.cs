namespace TrafficLights
{
    public partial class Form1 : Form
    {
        bool player = true; //true- first player,  false - second player

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


        public Form1()
        {
            InitializeComponent();

            //The region for front-coding
            #region


            btn = new Button();     //btn - name buttons for the playeing field


            buttonList.Add(btn);    //List of the buttons on the playeing field 
            this.Controls.Add(btn);
            #endregion



            //Click on the button
            foreach (Button btn in buttonList)
            {
                btn.Click += (e, sender) =>
                {
                    btn.Font = new Font("Times New Roman", 35, FontStyle.Bold);
                    if (player)
                    {
                        btn.Text = "X";
                        btn.BackColor == Color.Green;
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
                        btn.BackColor == Color.Yellow;
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
            }
        }
        Button btn;
        List<Button> buttonList = new List<Button>();
    }
}