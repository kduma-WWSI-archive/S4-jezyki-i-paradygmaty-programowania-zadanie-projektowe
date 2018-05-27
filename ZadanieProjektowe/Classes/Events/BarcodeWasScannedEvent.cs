namespace ZadanieProjektowe.Classes.Events
{
    public class BarcodeWasScannedEvent
    {
        public string Barcode;

        public BarcodeWasScannedEvent(string barcode)
        {
            Barcode = barcode;
        }
    }
}