namespace GameBloc.Models.Entity
{
    public interface IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Stylistics { get; set; }
        public string YearRelease { get; set; }
        public string Author { get; set; }
        public string Feelings { get; set; }
    }
}
