namespace movie.Entities
{
	public class Movie
	{
		//This will map to the primary key
		public int MovieId { get; set; }
		public string? Name { get; set; }
		public int? Year { get; set; }
		public int? Rating { get; set; }
	}
}
