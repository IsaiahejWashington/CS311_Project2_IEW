namespace Craps
{
    public partial class FrmCraps : Form
    {
        public FrmCraps()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            calculate_score();
        }//end label1

        private void lblDice2_Click(object sender, EventArgs e)
        {
            calculate_score();
            ;
        }//end lblDice2

        private void FrmCraps_Load(object sender, EventArgs e)
        {

        }//end FrmCraps

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int balance = 100;
            int bet =0;
            Console.WriteLine(bet -= balance);
        }//end textBox1

        private void lblBankBalance_Click(object sender, EventArgs e)
        {
            int balance = 100;
        }//end lblBankBalance

        private void btnRoll_Click(object sender, EventArgs e)
        {
            calculate_score();
        }//end btnRoll





        private void calculate_score()
        {

            Random rnd = new Random();
            int num1 = rnd.Next();
            for (int d = 0; d < num1; d++)
            {
                Console.WriteLine(rnd.Next(1, 6));
            }

            int num2 = rnd.Next();
            for (int d = 0; d < num2; d++)
            {
                Console.WriteLine(rnd.Next(1, 6));
            }


            Console.WriteLine(num1 -= num2);



        }//end calculate_score

        
    }//end class 

}//end namespace
