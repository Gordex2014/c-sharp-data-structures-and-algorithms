using System;
using System.Collections.Concurrent;

namespace CallCenterMany
{
    public class CallCenterMany
    {
        private int _counter = 0;
        public ConcurrentQueue<IncomingCallMany> Calls { get; private set; }

        public CallCenterMany()
        {
            Calls = new ConcurrentQueue<IncomingCallMany>();
        }

        public int Call(int clientId)
        {
            IncomingCallMany call = new IncomingCallMany()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now
            };
            Calls.Enqueue(call);
            return Calls.Count;
        }

        public IncomingCallMany Answer(string consultant)
        {
            if (Calls.Count > 0 && Calls.TryDequeue(out IncomingCallMany call))
            {
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;
                return call;
            }

            return null;
        }

        public void End(IncomingCallMany call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }
}