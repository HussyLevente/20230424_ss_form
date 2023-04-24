namespace _20230424_ss_form
{

    public partial class Form1 : Form
    {
        static double celsius;
        public Form1()
        {
            InitializeComponent();

        }

        private void kelvin_valto_Click(object sender, EventArgs e)
        {
            celsius = double.Parse(celsius_bevitel.Text);
            double kelvin = celsius + 273.15;
            kelvin_kiir.Text = kelvin.ToString();
        }

        private void fahrenheit_valto_Click(object sender, EventArgs e)
        {
            celsius = double.Parse(celsius_bevitel.Text);
            double fahrenheit = celsius * 1.8 + 32;
            fahrenheit_kiir.Text = fahrenheit.ToString();
        }
    }
}