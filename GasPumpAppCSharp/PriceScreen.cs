using System;
using System.Threading;
using System.Windows.Forms;

namespace GasPumpAppCSharp
{
    public partial class PriceScreen : Form
    {
        private Thread th;
        private double startVolume;
        private double fuelChosenUnitPrice;
        private double price;
        VisualScreen visualScreen;

        public PriceScreen(VisualScreen v)
        {
            InitializeComponent();
            this.visualScreen = v;
            this.visualScreen.UpdateFuelPriceAfterChoiceTextBox += VisualScreen_UpdateFuelPriceAfterChoiceTextBox;
            startVolume = 0.00;
            volumeTextBoxDisable.Text = String.Format("{0:0.00}", startVolume);
            priceTextBoxDisable.Text = "0,00";
            unitPriceTextBoxDisable.Text = "0,00";
        }

        private void VisualScreen_UpdateFuelPriceAfterChoiceTextBox(object sender, double unitPrice)
        {
            unitPriceTextBoxDisable.Text = Convert.ToString(unitPrice);
            fuelChosenUnitPrice = unitPrice;
            startVolume = 0.00;
            volumeTextBoxDisable.Text = String.Format("{0:0.00}", startVolume);
            priceTextBoxDisable.Text = "0,00";
            
        }

        delegate void UpdateDelegate();

        public void F_UpdateFuelDelivery(object sender, MonitorScreen.ButtonValue e)
        {
            if (e.buttonName != "releaseTriggerBtn")
            {
                th = new Thread(() => WorkThreadFunction(e.buttonName));
                th.Start();
            }
            else
            {
                th.Abort();
            }
        }

        private void WorkThreadFunction(string buttonName)
        {
            try
            {
                while (price <= 120.00)
                {
                    startVolume += 0.01;
                    UpdateValueVolume();
                    UpdateValuePrice();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void UpdateValueVolume()
        {
            try
            { 
                if (volumeTextBoxDisable.InvokeRequired)
                    this.Invoke(new UpdateDelegate(UpdateValueVolume));
                else
                {
                    volumeTextBoxDisable.Text = String.Format("{0:0.00}", startVolume);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}

        private void UpdateValuePrice()
        {
            try
            { 
                if (priceTextBoxDisable.InvokeRequired)
                    this.Invoke(new UpdateDelegate(UpdateValuePrice));
                else
                {
                    price = startVolume * fuelChosenUnitPrice;
                    priceTextBoxDisable.Text = String.Format("{0:0.00}", price);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
}
    }
}
