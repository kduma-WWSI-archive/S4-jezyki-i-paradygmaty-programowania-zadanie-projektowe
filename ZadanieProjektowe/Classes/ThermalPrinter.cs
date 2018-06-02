using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using PubSub;
using ZadanieProjektowe.Classes.Events;

namespace ZadanieProjektowe.Classes
{
    public class ThermalPrinter
    {
        private readonly SerialPort _serialPort;
        private readonly string _portName;
        private readonly int _baudRate;

        public ThermalPrinter(string portName = "COM5", int baudRate = 115200)
        {
            _baudRate = baudRate;
            _portName = portName;
            _serialPort = new SerialPort
            {
                BaudRate = baudRate,
                PortName = portName,
                NewLine = "\r\n",
                Encoding = Encoding.ASCII
            };

            this.Subscribe<NewPrintoutEvent>(NewPrintoutHandler);
        }

        private void NewPrintoutHandler(NewPrintoutEvent obj)
        {
            var bytes = obj.GetPrintout();
            _serialPort.Write(bytes.ToArray(), 0, bytes.Count);
        }

        public void Start()
        {
            try
            {
                _serialPort.Open();
                _serialPort.DiscardInBuffer();
            }
            catch
            {
                this.Publish(new CantConnectToTheThermalPrinterEvent(_portName, _baudRate));
            }
        }
    }
}