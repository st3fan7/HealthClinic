namespace HealthClinic
{
    internal class InventaryRoomCSVConverter : global::Repository.Csv.Converter.ICSVConverter<InventaryRoom>
    {
        private string cSV_DELIMITER;

        public InventaryRoomCSVConverter(string cSV_DELIMITER)
        {
            this.cSV_DELIMITER = cSV_DELIMITER;
        }
    }
}