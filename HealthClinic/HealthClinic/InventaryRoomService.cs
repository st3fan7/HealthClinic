namespace HealthClinic
{
    internal class InventaryRoomService
    {
        private InventaryRoomRepository inventaryRoomRepository;

        public InventaryRoomService(InventaryRoomRepository inventaryRoomRepository)
        {
            this.inventaryRoomRepository = inventaryRoomRepository;
        }
    }
}