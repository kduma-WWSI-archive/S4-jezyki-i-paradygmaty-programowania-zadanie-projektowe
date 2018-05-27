namespace ZadanieProjektowe.Classes.Events
{
    public class CantConnectToTheBarcodeReaderEvent
    {
        public readonly string PortName;
        public readonly int BaudRate;

        public CantConnectToTheBarcodeReaderEvent(string portName, int baudRate)
        {
            PortName = portName;
            BaudRate = baudRate;
        }
    }
}