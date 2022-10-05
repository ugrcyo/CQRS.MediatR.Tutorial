using DAL.CQRS.Entities;

namespace CQRS.DAL
{
    public static class ApplicationDbContext
    {
        static List<Developer> developerList = new List<Developer> {
         new() { Id = Guid.NewGuid(), Name = "Developer", Surname = "1", Title = "Junior Developer", CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Developer", Surname = "2", Title = "Mid-Level Developer", CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Developer", Surname = "3", Title = "Senior Developer", CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Developer", Surname = "4", Title = "Expert Developer", CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Developer", Surname = "5", Title = "Team Lead", CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Developer", Surname = "6", Title = "Software Architect", CreateTime = DateTime.Now }
        };
        public static List<Developer> DeveloperList => developerList;
    }
}
