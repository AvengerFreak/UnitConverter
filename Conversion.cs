using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Converter
{
    public partial class Conversion : Form
    {
        float kelvinConversionRate;
        float celsisFarenhietConversionRate;

        float cmConversionRateToMeter;
        float cmConversionRateToFt;
        float mConversionRateToCentimeter;
        float mConversionRateToFt;
        float ftConversionRateToCentimeter;
        float ftConversionRateToMeter;

        float kgPerCmSquaredConversionRateToPsi;
        float kgPerCmSquaredConversionRateToKPa;
        float psiConversionRateTokgPerCmSquared;
        float psiConversionRateToKPa;
        float kPaConversionRateToKgPerCmSquared;
        float kPaConversionRateToPsi;
        

        public Conversion()
        {
            InitializeComponent();
        }

        private void convertTemperature() { 
        
            string input =  Temperature_TextBox.Text;

            float initialValue = (float) Convert.ToDouble(input);

            int selectedIndex = Temperature_ComboBox.SelectedIndex;

            StringBuilder stringBuilder = new StringBuilder("");

            float celsius = 0.0f, farenhiet = 0.0f, kelvin= 0.0f;

            switch (selectedIndex)
            {
                case 0: // Celsius

                     celsius = initialValue;
                     farenhiet = (initialValue * (9/5)) + celsisFarenhietConversionRate;
                     kelvin = initialValue + kelvinConversionRate;


                    break;

                case 1: // Farenhiet

                    farenhiet = initialValue;
                    celsius = (initialValue - celsisFarenhietConversionRate) * (5 / 9);
                    kelvin = celsius + kelvinConversionRate;
                    
                    break;

                case 2: // Kelvin

                    kelvin = initialValue;
                    celsius = initialValue - kelvinConversionRate;
                    farenhiet = (celsius * (9 / 5)) + celsisFarenhietConversionRate;

                    break;
            }

            stringBuilder.Append("Celsius " + celsius + "\r\n\r\n");
            stringBuilder.Append("Farenhiet " + farenhiet + "\r\n\r\n");
            stringBuilder.Append("Kelvin " + kelvin + "\r\n\r\n");
            stringBuilder.Append("se esta calentando la cosa");

            Temperature_Convertion_View.Text = stringBuilder.ToString();
        }


        private void convertMass()
        {

            string input = Mass_TextBox.Text;

            float initialValue = (float)Convert.ToDouble(input);

            int selectedIndex = Mass_ComboBox.SelectedIndex;

            StringBuilder stringBuilder = new StringBuilder("");
            float cm = 0.0f, m = 0.0f, ft = 0.0f;

            switch (selectedIndex)
            {
                case 0: // cm cubico

                    cm = initialValue;
                    m = initialValue * cmConversionRateToMeter;
                    ft = initialValue * cmConversionRateToFt;

                    break;

                case 1: // m cubico

                    m = initialValue;
                    cm = initialValue * mConversionRateToCentimeter;
                    ft = initialValue * mConversionRateToFt;

                    break;

                case 2: // pies

                    ft = initialValue;
                    cm = ftConversionRateToCentimeter;
                    m = ftConversionRateToMeter;

                    break;
            }

            stringBuilder.Append("Centimetros cubicos " + cm + "\r\n\r\n");
            stringBuilder.Append("Metros cubicos " + m + "\r\n\r\n");
            stringBuilder.Append("Pies " + ft + "\r\n\r\n");
            stringBuilder.Append("se esta alargando la cosa");

            Mass_Convertion_View.Text = stringBuilder.ToString();
        }

        private void convertPressure()
        {

            string input = Pressure_TextBox.Text;

            float initialValue = (float)Convert.ToDouble(input);

            int selectedIndex = Pressure_ComboBox.SelectedIndex;

            StringBuilder stringBuilder = new StringBuilder("");

            float kgPerCmSquared = 0.0f, psi = 0.0f, kPa = 0.0f;

            switch (selectedIndex)
            {
                case 0: // kg/cm^2

                    kgPerCmSquared = initialValue;
                    psi = initialValue * kgPerCmSquaredConversionRateToPsi;
                    kPa = initialValue * kgPerCmSquaredConversionRateToKPa;

                    break;

                case 1: // PSI

                    psi = initialValue;
                    kgPerCmSquared = initialValue * psiConversionRateTokgPerCmSquared;
                    kPa = initialValue * psiConversionRateToKPa;

                    break;

                case 2: // KPa

                    kPa = initialValue;
                    kgPerCmSquared = initialValue * kPaConversionRateToKgPerCmSquared;
                    psi = initialValue * kPaConversionRateToPsi;

                    break;
            }

            stringBuilder.Append("kg/cm^2 " + kgPerCmSquared + "\r\n\r\n");
            stringBuilder.Append("PSI " + psi + "\r\n\r\n");
            stringBuilder.Append("KPa " + kPa + "\r\n\r\n");
            stringBuilder.Append("se esta apresionando la cosa");

            Pressure_Convertion_View.Text = stringBuilder.ToString();
        }

        private void Convert_Btn_Click(object sender, EventArgs e)
        {

            getConversionRates();
            convertTemperature();
            convertMass();
            convertPressure();

        }

        private void getConversionRates()
        {
            string pathToFile = "C:\\Users\\starw\\source\\repos\\Converter\\Conversions.txt";
            string[] lines = File.ReadAllLines(pathToFile);

            kelvinConversionRate = (float)Convert.ToDouble(lines[0]);
            celsisFarenhietConversionRate = (float)Convert.ToDouble(lines[1]);

            cmConversionRateToMeter = (float)Convert.ToDouble(lines[2]);
            cmConversionRateToFt = (float)Convert.ToDouble(lines[3]);
            mConversionRateToCentimeter = (float)Convert.ToDouble(lines[4]);
            mConversionRateToFt = (float)Convert.ToDouble(lines[5]);
            ftConversionRateToCentimeter = (float)Convert.ToDouble(lines[6]);
            ftConversionRateToMeter = (float)Convert.ToDouble(lines[7]);

            kgPerCmSquaredConversionRateToPsi = (float)Convert.ToDouble(lines[8]);
            kgPerCmSquaredConversionRateToKPa = (float)Convert.ToDouble(lines[9]);
            psiConversionRateTokgPerCmSquared = (float)Convert.ToDouble(lines[10]);
            psiConversionRateToKPa = (float)Convert.ToDouble(lines[11]);
            kPaConversionRateToKgPerCmSquared = (float)Convert.ToDouble(lines[12]);
            kPaConversionRateToPsi = (float)Convert.ToDouble(lines[13]);

        }
    }
}
