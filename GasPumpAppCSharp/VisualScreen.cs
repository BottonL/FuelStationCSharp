using System;
using System.Configuration;
using System.Windows.Forms;

namespace GasPumpAppCSharp
{
    public partial class VisualScreen : Form
    {
        private int numberTryPinCode;
        public static EnumState stateApp;
        public event EventHandler<EnumState> UpdateState;
        public event EventHandler<double> UpdateFuelPriceAfterChoiceTextBox;
        private enum EnumTicket { Default, Ticket, TicketAndDuplicata, NoTicket }
        private static EnumTicket chooseTicket;
        private bool enterPinOk;
        public VisualScreen()
        {
            InitializeComponent();
            stateApp = EnumState.Welcome;
            enterPinOk = false;
            numberTryPinCode = 0;
            chooseTicket = EnumTicket.Default;
            PriceScreen priceUI = new PriceScreen(this);
            MonitorScreen monitorUI = new MonitorScreen(this);
            priceUI.Show();
            monitorUI.Show();
            monitorUI.UpdateMonitorScreen += F_UpdateMonitorScreen;
            monitorUI.UpdateFuelDelivery += priceUI.F_UpdateFuelDelivery;
            monitorUI.UpdateFuelDelivery += F_UpdateMonitorScreen;
            boardPinCode1.TapPinCode += F_TapPinCode;
        }

        private void F_TapPinCode(object sender, boardPinCode.ButtonValue e)
        {
            if (this.textBox1.TextLength < 4 || e.buttonText == "C")
                if (e.buttonText != "C")
                    this.textBox1.Text += e.buttonText;
                else
                    if (this.textBox1.TextLength > 0)
                        this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1);
        }

        private void VisualScreen_Load(object sender, EventArgs e)
        {
            fuelPanel.Visible = false;
            insertCardPanel.Visible = false;
            deliveryPanel.Visible = false;
            tapPinCodePanel.Visible = false;
            thanksPanel.Visible = false;
            ticketPanel.Visible = false;
            usePanel.Visible = false;
            welcomePanel.Visible = false;
            removeCardPanel.Visible = false;
            pumpNozzleWithoutFuelChoicePanel.Visible = false;
            takeTicketPanel.Visible = false;

            if (UpdateState != null)
                UpdateState(this, stateApp);
        }

        private void F_UpdateMonitorScreen(object sender, MonitorScreen.ButtonValue args)
        {

            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }

            switch (args.buttonName)
            {
                case "insertCardBtn":
                    numberTryPinCode = 0;
                    this.textBox1.Clear();
                    tapPinCodePanel.Size = this.Size;
                    tapPinCodePanel.AutoSize = true;
                    tapPinCodePanel.Visible = true;
                    falseCodePinCardLabel.Visible = false;
                    stateApp = EnumState.TapCode;
                    if (UpdateState != null)
                        UpdateState(this, stateApp);
                    break;
                case "removeCardBtn":
                    if (stateApp == EnumState.CodePinOk)
                    {
                        fuelPanel.Size = this.Size;
                        fuelPanel.AutoSize = true;
                        fuelPanel.Visible = true;
                        stateApp = EnumState.CodePinOk;
                    }
                    else
                    {
                        screenLabel.Visible = true;
                        stateApp = EnumState.Welcome;
                    }
                    if (UpdateState != null)
                        UpdateState(this, stateApp);
                    break;
                case "takePumpNozzleBtn":
                    stateApp = EnumState.TakePumpNozzleBeforeChoiceAction;
                    if (UpdateState != null)
                        UpdateState(this, stateApp);
                    break;
                case "takeGoodPumpNozzleBtn":
                    if (stateApp == EnumState.TicketChosen)
                    {
                        stateApp = EnumState.TakePumpNozzle;
                        if (UpdateState != null)
                            UpdateState(this, stateApp);
                    }
                    else
                    {
                        chooseTicket = EnumTicket.NoTicket;
                        stateApp = EnumState.TakePumpNozzle;
                        if (UpdateState != null)
                            UpdateState(this, stateApp);
                    }
                    break;
                case "takeBadPumpNozzleBtn":
                    stateApp = EnumState.NoActionAllowed;
                    if (UpdateState != null)
                        UpdateState(this, stateApp);
                    break;
                case "pushTriggerBtn":
                    if(stateApp == EnumState.NoActionAllowed)
                    {
                        chooseTicket = EnumTicket.NoTicket;
                        stateApp = EnumState.NoDeliveryAllowed;
                        if (UpdateState != null)
                            UpdateState(this, stateApp);
                    }
                    else
                    {
                        deliveryPanel.Size = this.Size;
                        deliveryPanel.AutoSize = true;
                        deliveryPanel.Visible = true;
                        stateApp = EnumState.PushTrigger;
                        if (UpdateState != null)
                            UpdateState(this, stateApp);
                    }
                    break;
                case "releaseTriggerBtn":
                    stateApp = EnumState.ReleaseTrigger;
                    if (UpdateState != null)
                        UpdateState(this, stateApp);
                    break;
                case "releasePumpNozzleBtn":
                    if (!(chooseTicket == EnumTicket.NoTicket))
                    {
                        stateApp = EnumState.Ticket;
                        if (UpdateState != null)
                            UpdateState(this, stateApp);
                        takeTicketPanel.Visible = true;
                    }
                    else
                    {
                        stateApp = EnumState.Welcome;
                        if (UpdateState != null)
                            UpdateState(this, stateApp);
                        thanksPanel.Size = this.Size;
                        thanksPanel.AutoSize = true;
                        thanksPanel.Visible = true;
                    }
                    break;
                case "takeTicketBtn":
                    stateApp = EnumState.Welcome;
                    if (UpdateState != null)
                        UpdateState(this, stateApp);
                    thanksPanel.Size = this.Size;
                    thanksPanel.AutoSize = true;
                    thanksPanel.Visible = true;
                    break;
                default:
                    stateApp = EnumState.Welcome;
                    if (UpdateState != null)
                        UpdateState(this, stateApp);
                    welcomePanel.Size = this.Size;
                    welcomePanel.AutoSize = true;
                    welcomePanel.Visible = true;
                    break;
            }
        }

        private void CancelPinCodeBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.Visible = false;
            }
            screenLabel.Visible = true;
        }

        private void ValidatePinCodeBtn_Click(object sender, EventArgs e)
        {
           if(this.textBox1.TextLength == 4)
           {
                if(this.textBox1.Text == ConfigurationManager.AppSettings["PinCode"]) {
                    stateApp = EnumState.CodePinOk;
                    enterPinOk = true;
                    tapPinCodePanel.Visible = false;
                    removeCardPanel.Size = this.Size;
                    removeCardPanel.AutoSize = true;
                    removeCardPanel.Visible = true;
                    numberTryPinCode = 0;
                }
                else
                {
                    if(numberTryPinCode == 2)
                    {
                        falseCodePinCardLabel.Text = "Carte bloquée, veuillez la retirer.";
                    }
                    else
                    {
                        numberTryPinCode += 1;
                        falseCodePinCardLabel.Text = "Code faux. Il vous reste " + (3 - numberTryPinCode) + " essais.";
                        falseCodePinCardLabel.Visible = true;
                        textBox1.Clear();
                    }
                }
            }
        }

        private void TicketOption_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "ticketBtn":
                    chooseTicket = EnumTicket.Ticket;
                    break;
                case "ticketDuplicataBtn":
                    chooseTicket = EnumTicket.TicketAndDuplicata;
                    break;
                default:
                    chooseTicket = EnumTicket.NoTicket;
                    break;
            }

            ticketPanel.Visible = false;

            usePanel.Size = this.Size;
            usePanel.AutoSize = true;
            usePanel.Visible = true;

            stateApp = EnumState.TicketChosen;
            if (UpdateState != null)
                UpdateState(this, stateApp);
        }


        private void ButtonChoiceFuel_Click(object sender, EventArgs e)
        {
            double price = 0;
            switch (((Button)sender).Name)
            {
                case "sansPlomb95Btn":
                    price = Convert.ToDouble(ConfigurationManager.AppSettings["SansPlomb95"]);
                    break;
                case "sansPlomb95E10Btn":
                    price = Convert.ToDouble(ConfigurationManager.AppSettings["SansPlomb95E10"]);
                    break;
                case "sansPlomb98Btn":
                    price = Convert.ToDouble(ConfigurationManager.AppSettings["SansPlomb98"]);
                    break;
                case "gplBtn":
                    price = Convert.ToDouble(ConfigurationManager.AppSettings["GPL"]);
                    break;
                default:
                    price = Convert.ToDouble(ConfigurationManager.AppSettings["Gazole"]);
                    break;
            }
            if (UpdateFuelPriceAfterChoiceTextBox != null)
                UpdateFuelPriceAfterChoiceTextBox(this, price);

            fuelPanel.Visible = false;

            ticketPanel.Size = this.Size;
            ticketPanel.AutoSize = true;
            ticketPanel.Visible = true;

            stateApp = EnumState.FuelChosen;
            if (UpdateState != null)
                UpdateState(this, stateApp);
        }
    }
}
