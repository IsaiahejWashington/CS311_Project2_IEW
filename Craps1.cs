using System.Data.SqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Craps1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//end textBox1

        private void lbl3_Click(object sender, EventArgs e)
        {
            float money = 100;
            money--;
            money++;


        }// end lbl3

        private void btnRoll_Click(object sender, EventArgs e)
        {
            float money = 100;
            money--;
            txtBoxBet.Text = money.ToString("C");
            calculate_score();

        }//end btnRoll 

        private void lblDice1_Click(object sender, EventArgs e)
        {

            calculate_score();
        }//end lbl Dice1

        private void lblDice2_Click(object sender, EventArgs e)
        {
            calculate_score();
        }//end lbl Dice2

        private void lblWin_Click(object sender, EventArgs e)
        {
            calculate_score();

        }//end lblWin

        private void lblLose_Click(object sender, EventArgs e)
        {
            calculate_score();
        }//end lblLose

        private void lblPoint_Click(object sender, EventArgs e)
        {
            calculate_score();
        }//end lblPoint

        private void calculate_score()
        {
            Random rand = new Random();
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            int sum = dice1 + dice2;

            String outcomeMessage;
            switch (sum)
            {
                case 7:
                case 11:
                    outcomeMessage = "You win!";
                    break;

                case 2:
                case 3:
                case 12:
                    outcomeMessage = "You Lose!";
                    break;

                default:
                    outcomeMessage = "Roll again!";
                    break;
            }//end calculate_score




        }
    }//end class
}//end namespace
