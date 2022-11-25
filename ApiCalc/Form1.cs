using System.Xml.Linq;

namespace ApiCalc
{
    public partial class Form1 : Form
    {
        private Dictionary<string, float> _rates = new Dictionary<string, float>();
        public Form1()
        {
            InitializeComponent();
        }

        private void fetchApiButton_Click(object sender, EventArgs e)
        {
            XDocument api = XDocument.Load("http://api.nbp.pl/api/exchangerates/tables/a/?format=xml");
            var rates = api.Descendants("Rate");
            //czyœcimy s³ownik
            _rates.Clear();
            //parsujemy api
            foreach (var rate in rates)
            {
                
                if (rate.Element("Code") != null && rate.Element("Mid") != null)
                {
                    //wyci¹gnij sobie skót nazwy waluty z api
                    string code = rate.Element("Code").Value;
                    //wyci¹gnij sobie kurs waluty z api i przekonwertuj na float
                    float mid = float.Parse(rate.Element("Mid").Value, System.Globalization.CultureInfo.InvariantCulture);
                    //dodaj do s³ownika kurs waluty
                    _rates.Add(code, mid);
                }   
            }
            //wypisujemy kursy na ekranie
            rateUSDTextBox.Text = _rates["USD"].ToString();
            rateEURTextBox.Text = _rates["EUR"].ToString();
            rateCHFTextBox.Text = _rates["CHF"].ToString();
        }

        private void Exchange(object sender, EventArgs e)
        {
            //pobierz sobie tekst z radiobuttona

            string currency = (sender as RadioButton).Text;
            float ammountPLN = float.Parse(ammountPLNTextBox.Text, System.Globalization.CultureInfo.InvariantCulture);
            float rate = _rates[currency];
            float ammountExchanged = ammountPLN / rate;
            calculatedAmmountTextBox.Text = ammountExchanged.ToString();
            
        }
    }
}