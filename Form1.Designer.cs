namespace BurgerKiosk
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
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            grpMenu = new GroupBox();
            grpAdditional = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lblTotalPrice = new Label();
            lstOrderlist = new ListBox();
            btnOrder = new Button();
            btnClear = new Button();
            lblErrorMsg = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpMenu.SuspendLayout();
            grpAdditional.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.FromArgb(0, 0, 192);
            lblTitle.Location = new Point(36, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(308, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imghamburger;
            pictureBox1.Location = new Point(132, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imgbulgogiburger;
            pictureBox2.Location = new Point(132, 121);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 94);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.imgchickenburger;
            pictureBox3.Location = new Point(132, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 98);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Location = new Point(9, 56);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(76, 25);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            rdoHamBurger.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Location = new Point(9, 160);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(108, 25);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            rdoBulgogiBurger.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Location = new Point(9, 266);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(92, 25);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            rdoChickenBurger.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(pictureBox1);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(pictureBox3);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(pictureBox2);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 12F);
            grpMenu.ForeColor = SystemColors.ControlText;
            grpMenu.Location = new Point(63, 92);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(245, 332);
            grpMenu.TabIndex = 2;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴선택";
            // 
            // grpAdditional
            // 
            grpAdditional.Controls.Add(chkSauce);
            grpAdditional.Controls.Add(chkCheese);
            grpAdditional.Controls.Add(chkCola);
            grpAdditional.Controls.Add(chkPotato);
            grpAdditional.Font = new Font("맑은 고딕", 12F);
            grpAdditional.Location = new Point(348, 92);
            grpAdditional.Name = "grpAdditional";
            grpAdditional.Size = new Size(164, 233);
            grpAdditional.TabIndex = 3;
            grpAdditional.TabStop = false;
            grpAdditional.Text = "추가메뉴";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Location = new Point(27, 180);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(93, 25);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스추가";
            chkSauce.UseVisualStyleBackColor = true;
            chkSauce.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Location = new Point(27, 135);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(93, 25);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈추가";
            chkCheese.UseVisualStyleBackColor = true;
            chkCheese.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Location = new Point(27, 90);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(61, 25);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            chkCola.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Location = new Point(27, 45);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(93, 25);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            chkPotato.CheckedChanged += chkCheese_CheckedChanged;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalPrice);
            grpOrder.Controls.Add(lstOrderlist);
            grpOrder.Font = new Font("맑은 고딕", 12F);
            grpOrder.Location = new Point(556, 92);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(200, 291);
            grpOrder.TabIndex = 5;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문내역";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(41, 245);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(111, 21);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "총 금액 : 0 원";
            // 
            // lstOrderlist
            // 
            lstOrderlist.FormattingEnabled = true;
            lstOrderlist.Location = new Point(6, 32);
            lstOrderlist.Name = "lstOrderlist";
            lstOrderlist.Size = new Size(188, 193);
            lstOrderlist.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.LimeGreen;
            btnOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = SystemColors.Control;
            btnOrder.Location = new Point(556, 389);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(101, 35);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(663, 388);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 36);
            btnClear.TabIndex = 1;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(588, 427);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(138, 15);
            lblErrorMsg.TabIndex = 8;
            lblErrorMsg.Text = "햄버거를 선택해 주세요.";
            lblErrorMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpAdditional);
            Controls.Add(grpMenu);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpAdditional.ResumeLayout(false);
            grpAdditional.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private GroupBox grpMenu;
        private GroupBox grpAdditional;
        private CheckBox chkPotato;
        private CheckBox chkSauce;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private GroupBox grpOrder;
        private Label lblTotalPrice;
        private ListBox lstOrderlist;
        private Button btnOrder;
        private Button btnClear;
        private Label lblErrorMsg;
    }
}
