using System;
using System.Windows.Forms;

namespace GasPumpAppCSharp
{
    public partial class MonitorScreen : Form
    {
        public event EventHandler<ButtonValue> UpdateMonitorScreen;
        public event EventHandler<ButtonValue> UpdateFuelDelivery;
        VisualScreen visualScreen;
        private bool deliveryAllowed;

        public MonitorScreen(VisualScreen v)
        {
            InitializeComponent();
            this.visualScreen = v;
            visualScreen.UpdateState += F_UpdateState;
            deliveryAllowed = true;
        }

        private void F_UpdateState(object sender, EnumState stateApp)
        {
            switch ((int)stateApp)
            {
                case 1:
                    //InsertCard
                    DisableAllBtn();
                    takeGoodPumpNozzleBtn.Enabled = true;
                    takeBadPumpNozzleBtn.Enabled = true;
                    removeCardBtn.Enabled = true;
                    break;
                case 2:
                    //TapCode
                    DisableAllBtn();
                    takeGoodPumpNozzleBtn.Enabled = true;
                    takeBadPumpNozzleBtn.Enabled = true;
                    removeCardBtn.Enabled = true;
                    break;
                case 3:
                case 11:
                    //TakePumpNozzle
                    DisableAllBtn();
                    pushTriggerBtn.Enabled = true;
                    releasePumpNozzleBtn.Enabled = true;
                    deliveryAllowed = true;
                    break;
                case 4:
                    //PushTrigger
                    DisableAllBtn();
                    releaseTriggerBtn.Enabled = true;
                    break;
                case 5:
                    //ReleaseTrigger
                    DisableAllBtn();
                    pushTriggerBtn.Enabled = true;
                    releasePumpNozzleBtn.Enabled = true;
                    break;
                case 6:
                    //ReleasePumpNozzle
                    DisableAllBtn();
                    touchScreenBtn.Enabled = true;
                    insertCardBtn.Enabled = true;
                    takePumpNozzleBtn.Enabled = true;
                    break;
                case 7:
                    //Ticket
                    DisableAllBtn();
                    takeTicketBtn.Enabled = true;
                    break;
                case 8:
                    //CodePinOk
                    DisableAllBtn();
                    takePumpNozzleBtn.Enabled = true;
                    break;
                case 9:
                case 10:
                    //FuelChosen and TicketChoosen
                    DisableAllBtn();
                    takeGoodPumpNozzleBtn.Enabled = true;
                    takeBadPumpNozzleBtn.Enabled = true;
                    takeGoodPumpNozzleBtn.Visible = true;
                    takeBadPumpNozzleBtn.Visible = true;
                    takePumpNozzleBtn.Visible = false;
                    break;
                case 12:
                    //NoDeliveryAllowed
                    DisableAllBtn();
                    deliveryAllowed = false;
                    releaseTriggerBtn.Enabled = true;
                    break;
                default:
                    //Welcome
                    DisableAllBtn();
                    touchScreenBtn.Enabled = true;
                    insertCardBtn.Enabled = true;
                    takeGoodPumpNozzleBtn.Visible = false;
                    takeBadPumpNozzleBtn.Visible = false;
                    takePumpNozzleBtn.Visible = true;
                    takePumpNozzleBtn.Enabled = true;
                    break;
            }
        }

        private void DisableAllBtn()
        {
            foreach (Control btn in this.Controls)
            {
                btn.Enabled = false;
            }
        }

        private void ButtonMonitor_Click(object sender, EventArgs e)
        {
            if (UpdateMonitorScreen != null)
                UpdateMonitorScreen(this, new ButtonValue { buttonName = ((Button)sender).Name });
        }

        private void ButtonFuel_Click(object sender, EventArgs e)
        {
            if (UpdateMonitorScreen != null)
                UpdateMonitorScreen(this, new ButtonValue { buttonName = ((Button)sender).Name });

            if (deliveryAllowed != false)
            {
                if (UpdateFuelDelivery != null)
                    UpdateFuelDelivery(this, new ButtonValue { buttonName = ((Button)sender).Name });
            }
        }

        public class ButtonValue : EventArgs
        {
            public string buttonName { get; set; }
        }

        private void MonitorScreen_Load(object sender, EventArgs e)
        {
            takeBadPumpNozzleBtn.Visible = false;
            takeGoodPumpNozzleBtn.Visible = false;
        }
    }
}
