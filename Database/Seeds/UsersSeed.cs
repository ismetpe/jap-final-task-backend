
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Infrastructure.Database.Seeds
{
    public class UsersSeed
    {
        public static List<User> Users { get; } = new()
        {
            new User { Id = 1, Username = "user1", Password = "123456" },
            new User { Id = 2, Username = "user2", Password = "123456" },
            new User { Id = 3, Username = "user3", Password = "123456" },
            new User { Id = 4, Username = "user4", Password = "123456" },
            new User { Id = 5, Username = "user5", Password = "123456" }
        };
    }
}
