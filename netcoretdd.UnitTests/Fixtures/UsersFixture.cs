using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using netcoretdd.API.Models;

namespace netcoretdd.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User {
                    Name = "Test User 1",
                    Email = "test.user.1@example.com",
                    Address = new Address {
                        Street = "123 Main St",
                        City = "Somewhere",
                        ZipCode = "213134",
                    }
                },
                new User {
                    Name = "Test User 2",
                    Email = "test.user.2@example.com",
                    Address = new Address {
                        Street = "900 Main St",
                        City = "Somewhere",
                        ZipCode = "213134",
                    }
                },
                new User {
                    Name = "Test User 3",
                    Email = "test.user.3@example.com",
                    Address = new Address {
                        Street = "106 Main St",
                        City = "Somewhere",
                        ZipCode = "213134",
                    }
                },
            };
    }
}
