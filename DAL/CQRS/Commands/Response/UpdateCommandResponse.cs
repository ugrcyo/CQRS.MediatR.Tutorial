namespace DAL.CQRS.Commands.Response
{
    public class UpdateCommandResponse
    {
        public bool IsSuccess { get; set; }
        public string Title { get; set; }
    }
}
