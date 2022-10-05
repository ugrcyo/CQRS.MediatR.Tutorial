namespace DAL.CQRS.Entities
{
    public class Developer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
