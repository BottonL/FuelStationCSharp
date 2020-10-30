using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasPumpAppCSharp
{
    public enum EnumState
    {
        Welcome,
        InsertCard,
        TapCode,
        TakePumpNozzle,
        PushTrigger,
        ReleaseTrigger,
        ReleasePumpNozzle,
        Ticket,
        CodePinOk,
        FuelChosen,
        TicketChosen,
        NoActionAllowed,
        NoDeliveryAllowed
    }
}
