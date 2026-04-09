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
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblErrorMsg.Visible = true;
                return;
            }

            if (rdoHamBurger.Checked)
            {
                totalPrice += 5000;
                lstOrderlist.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalPrice += 4000;
                lstOrderlist.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalPrice += 3000;
                lstOrderlist.Items.Add("치킨버거 3,000원");
            }

            if (chkPotato.Checked)
            {
                totalPrice += 3500;
                lstOrderlist.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                totalPrice += 2500;
                lstOrderlist.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                totalPrice += 1500;
                lstOrderlist.Items.Add("치즈추가 1,500원");
            }

            if (chkSauce.Checked)
            {
                totalPrice += 500;
                lstOrderlist.Items.Add("소스추가 500원");
            }

            lblErrorMsg.Visible = false;
            lblTotalPrice.Text = $"총 금액: {totalPrice}원";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            lblErrorMsg.Visible = false;

            lstOrderlist.Items.Clear();
            lblTotalPrice.Text = "총 금액: 0원";
        }
    }
}
