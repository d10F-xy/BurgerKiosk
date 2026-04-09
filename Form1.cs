namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public int totalPrice = 0;
        public Form1()
        {
            InitializeComponent();


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdoHamBurger.Checked)
            {
                totalPrice += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalPrice += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                totalPrice += 3000;
            }

            if (chkPotato.Checked)
            {
                totalPrice += 3500;
            }

            if (chkCola.Checked)
            {
                totalPrice += 2500;
            }

            if (chkCheese.Checked)
            {
                totalPrice += 1500;
            }

            if (chkSauce.Checked)
            {
                totalPrice += 500;
            }

        }
    }
}
