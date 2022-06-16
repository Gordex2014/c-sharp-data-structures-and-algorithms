using CallCenterMany;
using Queues.SingleConsultantCallCenter.Models;
using CallCenterMany;
using Queues.Utils;

var random = new Random();

// Single consultant call center
Printer.PrintTittle("Single consultant call center");
var singleCenter = new CallCenter();
singleCenter.Call(1234);
singleCenter.Call(5678);
singleCenter.Call(1468);
singleCenter.Call(9641);
while (singleCenter.AreWaitingCalls())
{
    var call = singleCenter.Answer("Pepe");
    Printer.Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}.");
    Thread.Sleep(random.Next(1000, 10000));
    singleCenter.End(call);
    Printer.Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}.");
}

// Multiple consultant call center
Printer.PrintTittle("Multiple consultant call center");
CallCenterManyProgram.Main();