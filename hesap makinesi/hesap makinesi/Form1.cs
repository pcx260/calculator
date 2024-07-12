namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        bool _izin = false;
        bool _izin2 = true;
        int _ilksayi;
        int _ikisayi;
        int _sonuc;
        bool _carp;
        bool _bol;
        bool _cýk;
        bool _top;
        public Form1()
        {
            InitializeComponent();

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "1";

            _izin = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "2";
            _izin = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "3";
            _izin = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "4";
            _izin = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "5";
            _izin = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "6";
            _izin = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "7";
            _izin = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "8";
            _izin = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "9";
            _izin = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "0";
            _izin = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (_izin==true && _izin2 == true)
            {
               
                _izin2 = false;
                _ilksayi = Convert.ToInt32(label1.Text);
                label1.Text = "";
                _top = true;
            }

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (_izin == true && _izin2 == true)
            {
                
                _izin2 = false;
                _ilksayi = Convert.ToInt32(label1.Text);
                label1.Text = "";
                _cýk = true;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (_izin == true && _izin2 == true)
            {
                
                _izin2 = false;
                _ilksayi = Convert.ToInt32(label1.Text);
                label1.Text = "";
                _carp = true;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (_izin == true &&_izin2==true)
            {
                
                _izin2 = false;
                _ilksayi = Convert.ToInt32(label1.Text);
                label1.Text = "";
                _bol = true;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (_izin == true && _izin2 == false)
            {
                _ikisayi = Convert.ToInt32(label1.Text);
            }

            if (_carp==true)
            {
                _sonuc = _ilksayi * _ikisayi;
            }

            if (_top==true)
            {
                _sonuc = _ilksayi + _ikisayi;
            }

            if (_cýk==true)
            {
                _sonuc = _ilksayi - _ikisayi;
            }

            if (_bol==true)
            {
                _sonuc = _ilksayi / _ikisayi;
            }
            MessageBox.Show(Convert.ToString(_sonuc));


            label1.Text =Convert.ToString(_sonuc);
            _izin2 = true;
        }
    }
}
