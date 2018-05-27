using System;
using System.IO.Ports;
using System.Windows.Forms;
using PubSub;
using ZadanieProjektowe.Classes.Events;

namespace ZadanieProjektowe.Classes
{
    public class BarCodeScanner
    {
        private readonly SerialPort _serialPort;
        private readonly string _portName;
        private readonly int _baudRate;

        public BarCodeScanner(string portName = "COM4", int baudRate = 115200)
        {
            _baudRate = baudRate;
            _portName = portName;
            _serialPort = new SerialPort
            {
                BaudRate = baudRate,
                PortName = portName,
                NewLine = "\r\n"
            };
            
            _serialPort.DataReceived += SerialPortDataReceived; ;
            this.Subscribe<BarcodeErrorEncounteredEvent>(BarcodeErrorEncounteredHandler);
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
                this.Publish(new CantConnectToTheBarcodeReaderEvent(_portName, _baudRate));
                //MessageBox.Show("Skaner Kodów Kreskowych nie został podłączony.\nSkanowanie kodów nie będzie możliwe.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BarcodeErrorEncounteredHandler(BarcodeErrorEncounteredEvent e)
        {
            _serialPort.WriteLine("$?GGG");
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (_serialPort.BytesToRead != 0)
            {
                this.Publish(
                    new BarcodeWasScannedEvent(
                        _serialPort.ReadLine().Trim()
                    )
                );
            }
        }
    }
}