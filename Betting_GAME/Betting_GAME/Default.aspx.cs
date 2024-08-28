using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Betting_GAME
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HideAllPlayerPanels();
            }
        }

        protected void numPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberOfPlayers = int.Parse(numPlayers.SelectedValue);
            p1i.Text = "0";
            p2i.Text = "0";
            p3i.Text = "0";
            p4i.Text = "0";
            HideAllPlayerPanels();
            ShowPlayerPanels(numberOfPlayers);
        }

        private void HideAllPlayerPanels()
        {
            player1Panel.Visible = false;
            player2Panel.Visible = false;
            player3Panel.Visible = false;
            player4Panel.Visible = false;
        }

        private void ShowPlayerPanels(int numberOfPlayers)
        {
            ResetButtonSizes();
            if (numberOfPlayers >= 1) player1Panel.Visible = true;
            if (numberOfPlayers >= 2) player2Panel.Visible = true;
            if (numberOfPlayers >= 3) player3Panel.Visible = true;
            if (numberOfPlayers >= 4) player4Panel.Visible = true;
        }

        protected void run_button_clicked(object sender, EventArgs e)
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue", "Yellow" };
            Random random = new Random();
            int randomIndex = random.Next(colors.Count);
            string randomColor = colors[randomIndex];
            String display_text = "";
            int am = 0;
            am = int.Parse(p1i.Text) + int.Parse(p2i.Text) + int.Parse(p3i.Text) + int.Parse(p4i.Text);
            am += int.Parse(amount.Text);
            if (randomColor.Equals("Red"))
            {
                if (ButtonRed1.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 1 is winner.\n";
                    display_text += $"Total amount = {p1.Text} + 300\n";
                    p1.Text = "" + ((int.Parse(p1.Text)) + 300);
                    am -= 300;
                }
                if (ButtonRed2.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 2 is winner.\n";
                    display_text += $"Total amount = {p2.Text} + 300\n";
                    p2.Text = "" + ((int.Parse(p2.Text)) + 300);
                    am -= 300;
                }
                if (ButtonRed3.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 3 is winner.\n";
                    display_text += $"Total amount = {p3.Text} + 300\n";
                    p3.Text = "" + ((int.Parse(p3.Text)) + 300);
                    am -= 300;
                }
                if (ButtonRed4.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 4 is winner.\n";
                    display_text += $"Total amount = {p4.Text} + 300\n";
                    p4.Text = "" + ((int.Parse(p4.Text)) + 300);
                    am -= 300;
                }
            }
            else if (randomColor.Equals("Green"))
            {
                if (ButtonGreen1.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 1 is winner.\n";
                    display_text += $"Total amount = {p1.Text} + 300\n";
                    p1.Text = "" + ((int.Parse(p1.Text)) + 300);
                    am -= 300;
                }
                if (ButtonGreen2.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 2 is winner.\n";
                    display_text += $"Total amount = {p2.Text} + 300\n";
                    p2.Text = "" + ((int.Parse(p2.Text)) + 300);
                    am -= 300;
                }
                if (ButtonGreen3.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 3 is winner.\n";
                    display_text += $"Total amount = {p3.Text} + 300\n";
                    p3.Text = "" + ((int.Parse(p3.Text)) + 300);
                    am -= 300;
                }
                if (ButtonGreen4.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 4 is winner.\n";
                    display_text += $"Total amount = {p4.Text} + 300\n";
                    p4.Text = "" + ((int.Parse(p4.Text)) + 300);
                    am -= 300;
                }
            }
            else if (randomColor.Equals("Blue"))
            {
                if (ButtonBlue1.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 1 is winner.\n";
                    display_text += $"Total amount = {p1.Text} + 300\n";
                    p1.Text = "" + ((int.Parse(p1.Text)) + 300);
                    am -= 300;
                }
                if (ButtonBlue2.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 2 is winner.\n";
                    display_text += $"Total amount = {p2.Text} + 300\n";
                    p2.Text = "" + ((int.Parse(p2.Text)) + 300);
                    am -= 300;
                }
                if (ButtonBlue3.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 3 is winner.\n";
                    display_text += $"Total amount = {p3.Text} + 300\n";
                    p3.Text = "" + ((int.Parse(p3.Text)) + 300);
                    am -= 300;
                }
                if (ButtonBlue4.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 4 is winner.\n";
                    display_text += $"Total amount = {p4.Text} + 300\n";
                    p4.Text = "" + ((int.Parse(p4.Text)) + 300);
                    am -= 300;
                }
            }
            else if (randomColor.Equals("Yellow"))
            {
                if (ButtonYellow1.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 1 is winner.\n";
                    display_text += $"Total amount = {p1.Text} + 300\n";
                    p1.Text = "" + ((int.Parse(p1.Text)) + 300);
                    am -= 300;
                }
                if (ButtonYellow2.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 2 is winner.\n";
                    display_text += $"Total amount = {p2.Text} + 300\n";
                    p2.Text = "" + ((int.Parse(p2.Text)) + 300);
                    am -= 300;
                }
                if (ButtonYellow3.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 3 is winner.\n";
                    display_text += $"Total amount = {p3.Text} + 300\n";
                    p3.Text = "" + ((int.Parse(p3.Text)) + 300);
                    am -= 300;
                }
                if (ButtonYellow4.Style["height"].Equals("30px"))
                {
                    display_text += "\nPlayer 4 is winner.\n";
                    display_text += $"Total amount = {p4.Text} + 300\n";
                    p4.Text = "" + ((int.Parse(p4.Text)) + 300);
                    am -= 300;
                }
            }
            amount.Text = "" + am;
            colorLabel.Text = "Winning Color is : "+ randomColor;
            colorBox.Style["background-color"] = randomColor.ToLower();
            colorBox.Visible = true;
            random_color.Visible = true;
            output_text.Text = display_text;
        }

        protected void ChangeColor(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Label investmentLabel = null;
            Label p_amount = null;

            // Determine which player's investment label to update
            switch (clickedButton.ID)
            {
                case "ButtonRed1":
                case "ButtonGreen1":
                case "ButtonBlue1":
                case "ButtonYellow1":
                    investmentLabel = p1i;
                    p_amount = p1;
                    break;
                case "ButtonRed2":
                case "ButtonGreen2":
                case "ButtonBlue2":
                case "ButtonYellow2":
                    investmentLabel = p2i;
                    p_amount = p2;
                    break;
                case "ButtonRed3":
                case "ButtonGreen3":
                case "ButtonBlue3":
                case "ButtonYellow3":
                    investmentLabel = p3i;
                    p_amount = p3;
                    break;
                case "ButtonRed4":
                case "ButtonGreen4":
                case "ButtonBlue4":
                case "ButtonYellow4":
                    investmentLabel = p4i;
                    p_amount = p4;
                    break;
            }

            if ((investmentLabel != null) && (p_amount!=null))
            {
                if (clickedButton.Style["height"].Equals("20px"))
                {
                    int i = int.Parse(investmentLabel.Text);
                    int j = int.Parse(p_amount.Text);
                    j -= 100;
                    p_amount.Text = "" + j;
                    i += 100;
                    investmentLabel.Text = "" + i;
                }
                clickedButton.Style["height"] = "30px";
                clickedButton.Style["width"] = "30px";
            }
        }

        private void ResetButtonSizes()
        {
            foreach (var buttonId in new[]
            {
                "ButtonRed1", "ButtonBlue1", "ButtonGreen1", "ButtonYellow1",
                "ButtonRed2", "ButtonBlue2", "ButtonGreen2", "ButtonYellow2",
                "ButtonRed3", "ButtonBlue3", "ButtonGreen3", "ButtonYellow3",
                "ButtonRed4", "ButtonBlue4", "ButtonGreen4", "ButtonYellow4"
            })
            {
                Button button = FindControl(buttonId) as Button;
                if (button != null)
                {
                    button.Style["width"] = "20px";
                    button.Style["height"] = "20px";
                }
            }
        }
    }
}
