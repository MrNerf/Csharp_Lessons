using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvents
{
    public class EventPersonExample
    {
        public EventHandler SleepHandler;
        public EventHandler Handler;
        public string Name { get; set; }

        public void TakeTime(int time)
        {
            if (time <6)
            {
                SleepHandler?.Invoke(this, null);
            }
            else
            {
                Handler.Invoke(this, EventArgs.Empty);
            }

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
