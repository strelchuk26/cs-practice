namespace MusicShopExam.Entities
{
	public class Genre
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Plate> Plates { get; set; }
        public ICollection<AvailablePlate> AvailablePlates { get; set; }

		public override string ToString() => Name;
	}
}