namespace ZadanieProjektowe.Classes.Events
{
    public class CantConnectToTheThermalPrinterEvent
    {
        public readonly string PortName;
        public readonly int BaudRate;

        public CantConnectToTheThermalPrinterEvent(string portName, int baudRate)
        {
            PortName = portName;
            BaudRate = baudRate;
        }
    }
}