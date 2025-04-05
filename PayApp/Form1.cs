namespace PayApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PaymentMethod? selectedPaymentMethod;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO : Bu kýsmý veritabanýndan elde etmiþ gibi bir simülasyon gerçekleþtireceðiz.
            List<PaymentMethod> paymentMethods = GetPaymentMethods();

            ClassGenerator classGenerator = new ClassGenerator();
            classGenerator.GenerateClasses(paymentMethods);

            foreach (var method in paymentMethods)
            {
                ComboBoxItem item = new ComboBoxItem
                {
                    Text = method.DisplayName,
                    Tag = method
                };

                cmbPaymentMethod.Items.Add(item);
            }

            cmbPaymentMethod.SelectedIndex = 0;
        }

        private List<PaymentMethod> GetPaymentMethods()
        {
            return new List<PaymentMethod>
            {
                new PaymentMethod("Credit Card", "CreditCard"),
                new PaymentMethod("Bank Transfer", "BankTransfer"),
                new PaymentMethod("Cash", "Cash"),
                new PaymentMethod("PayPal", "PayPal"),
                new PaymentMethod("Bitcoin", "Bitcoin"),
                new PaymentMethod("Wire Transfer", "WireTransfer"),
                new PaymentMethod("Apple Pay", "ApplePay"),
                new PaymentMethod("Google Pay", "GooglePay"),
                new PaymentMethod("Amazon Pay", "AmazonPay"),
                new PaymentMethod("Alipay", "Alipay")
            };
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem? selectedItem = cmbPaymentMethod.SelectedItem as ComboBoxItem;

            if (selectedItem != null)
            {
                selectedPaymentMethod = (PaymentMethod)selectedItem.Tag;
            }
            else
            {
                selectedPaymentMethod = null;
            }
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            lblPaymentStatus.Text = string.Empty;
            if (selectedPaymentMethod is not null)
            {
                if(string.IsNullOrEmpty(txtAmount.Text)) {
                    MessageBox.Show("Please enter the amount (Amount cannot be left blank)");
                }
                else
                {
                    decimal amount = decimal.Parse(txtAmount.Text);
                    PaymentMethodFactory factory = new PaymentMethodFactory();
                    IPaymentMethod paymentMethod = factory.CreatePaymentMethod(selectedPaymentMethod.ClassName);
                    PaymentMethodManager paymentMethodManager = new PaymentMethodManager(paymentMethod);
                    lblPaymentStatus.Text = paymentMethodManager.RetrievePaymentDetails(amount);
                }
            }
            else
            {
                MessageBox.Show("Please select a payment method");
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
