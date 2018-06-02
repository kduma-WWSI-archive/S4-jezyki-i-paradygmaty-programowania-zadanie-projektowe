using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieProjektowe.Classes.Events
{
    public class NewPrintoutEvent
    {

        protected List<byte> Bytes = new List<byte>();

        protected void _appendString(string s)
        {
            foreach (var b in Encoding.ASCII.GetBytes(s))
            {
                Bytes.Add(b);
            }
        }

        protected void _appendBytes(params byte[] values)
        {
            foreach (var b in values)
            {
                Bytes.Add(b);
            }
        }

        protected void _appendBytes(params char[] values)
        {
            foreach (var b in values)
            {
                Bytes.Add(Convert.ToByte(b));
            }
        }

        public NewPrintoutEvent()
        {
        }

        protected NewPrintoutEvent(string printout) => _appendString(printout);
    
        public virtual List<byte> GetPrintout() => Bytes;
    }
}