namespace DAL.CQRS.Commands.Response
{
    public class CreateCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid Id { get; set; }
    }
}
