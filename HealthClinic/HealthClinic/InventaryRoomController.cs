namespace HealthClinic
{
    public class InventaryRoomController
    {
        private InventaryRoomService inventaryRoomService;

        public InventaryRoomController(InventaryRoomService inventaryRoomService)
        {
            this.inventaryRoomService = inventaryRoomService;
        }
    }
}