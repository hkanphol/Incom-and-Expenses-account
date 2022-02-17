using System.Collections;

namespace Income_and_Expense_account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void save_button_Click(object sender, EventArgs e)
        {

        }

        private void save_Button_Click(object sender, EventArgs e)
        {

        }

        private void load_Button_Click(object sender, EventArgs e)
        {

        }

        private void income_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            IncomeCheck();
        }

        private void IncomeCheck()
        {
            bool state = true;

            if (Income_checkBox.Checked)
            {
                state = false;
            }

            Expenses_checkBox.Checked = state;
        }

        private void expenses_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            ExpensesChecked();
        }

        private void ExpensesChecked()
        {
            bool state = true;

            if (Expenses_checkBox.Checked)
            {
                state = false;
            }

            Income_checkBox.Checked = state;
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            ArrayList nameList = new ArrayList();
            ArrayList amountList = new ArrayList();
            string status = "";
            string Name, Amount;

            Name = nameBox.Text;
            Amount = amountBox.Text;

            if (Income_checkBox.Checked == true)
            {
                status = "";
                status = "Income";
            }
            else if (Expenses_checkBox.Checked == true)
            {
                status = "";
                status = "Expenses";
            }

            string textLine = Name + " " + Amount + " " + status + "\r\n";
            allList_Box.AppendText(textLine);
        }
    }
}