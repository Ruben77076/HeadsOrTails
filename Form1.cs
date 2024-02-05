using Microsoft.VisualBasic;

namespace HeadsOrTails
{
    public partial class Form1 : Form
    {
        int heads = 0;
        int tails = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowHeads_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Heads2;
            //Like a lightswitch when I press show heads the image of tails will turn off or be invisible

        }

        private void btnShowTails_Click(object sender, EventArgs e)
        {
            picCoins.Image = Properties.Resources.Tails2;
            //Like a lightswitch when I press show tails the image of heads will turn off or be invisible
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //button will close the application
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int randomNum = rdm.Next(1, 3);  //create a random number generator with only 1 or 2 as possible outcomes.

            if (randomNum == 1)                                        //random coin flip heads
            {
                btnShowHeads.PerformClick();                          //will click show heads 
                heads++;                                              //will increase counter by 1
                labelHeads.Text = "Heads # \n" + heads.ToString();   //display heads counter

            }
            else                                                     //random coin flip tails
            {
                btnShowTails.PerformClick();                        //will click show tails
                tails++;                                            //will increase counter by 1
                labelTails.Text = "Tails # \n" + tails.ToString(); //display tails counter
            }
        }

       
    }
}
