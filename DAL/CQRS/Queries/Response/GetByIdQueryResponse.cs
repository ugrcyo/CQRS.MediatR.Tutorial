
namespace DAL.CQRS.Queries.Response
{
    public class GetByIdQueryResponse 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
