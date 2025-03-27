namespace VehicleAPI.Models
{
    public class VehicleData
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int NewVehicleSales { get; set; }
        public int UsedVehicleSales { get; set; }
        public int InventoryLevels { get; set; }
        public int AppointmentSet { get; set; }   
        public int AppointmentClosed { get; set; } 
        public decimal AppointmentCloseRate 
        { 
            get 
            {
                return AppointmentSet > 0 ? ((decimal)AppointmentClosed / AppointmentSet) * 100 : 0;
            } 
        }
    }
}
