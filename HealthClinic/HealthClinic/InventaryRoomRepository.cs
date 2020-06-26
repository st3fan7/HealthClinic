using Repository.IDSequencer;

namespace HealthClinic
{
    internal class InventaryRoomRepository
    {
        private global::Repository.Csv.Stream.CSVStream<InventaryRoom> cSVStream;
        private IntSequencer intSequencer;

        public InventaryRoomRepository(global::Repository.Csv.Stream.CSVStream<InventaryRoom> cSVStream, IntSequencer intSequencer)
        {
            this.cSVStream = cSVStream;
            this.intSequencer = intSequencer;
        }
    }
}