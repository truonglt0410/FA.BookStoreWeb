using FA.BookStoreWeb.Data.Security;
using FA.BookStoreWeb.Models.Common;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FA.BookStoreWeb.Data
{
    // This is useful if you do not want to tear down the database each time you run the application.
    // public class ApplicationDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    // This example shows you how to create a new database if the Model changes
    public class BookStoreDbInitializer : DropCreateDatabaseIfModelChanges<BookStoreDbContext>
    {
        protected override void Seed(BookStoreDbContext context)
        {
            InitializeIdentity(context);
            // var categories = new Category[]
            //{
            //     new Category
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Literature & Fiction",
            //         Description ="Literature & Fiction Books",
            //         IsDeleted = false
            //     },
            //     new Category
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Self Help",
            //         Description ="Self Help Books Self Help Books",
            //         IsDeleted = false
            //     },
            //     new Category
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Romance",
            //         Description ="Book where the main character or characters fall in love.",
            //         IsDeleted = false
            //     },
            //     new Category
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Manga, Comic",
            //         Description ="Manga, Comic Books Manga, Comic Books",
            //         IsDeleted = false
            //     }
            //};

            // var publishers = new Publisher[]
            //{
            //     new Publisher
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Hachette Livre",
            //         Description ="Hachette Livre is another Big 5 publisher, the largest in France and one" +
            //         " of the most prominent publishers in all of Europe. It’s owned by the Lagardère Group " +
            //         "and encompasses over 150 imprints. Hachette Livre was officially formed in 1992, when " +
            //         "the publishing assets of Hachette SA (its former parent company) were collected into a " +
            //         "single subsidiary",
            //         IsDeleted = false
            //     },
            //     new Publisher
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Kim Dong",
            //         Description ="Kim Dong Publishing House is a Vietnamese publishing house specializing " +
            //         "in children's literature books, established on June 15, 1956 in Hanoi. In addition, " +
            //         "Kim Dong also cooperates with more than 70 publishers around the world such as Dorling " +
            //         "Kindersley, HarperCollins UK, Simon and Schuster UK, Dami International, Shogakukan , " +
            //         "Kodansha , Shuiesha , Square Enix , Seoul publisher and Neung-In publishing house (Korea).",
            //         IsDeleted = false
            //     },
            //     new Publisher
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "First News",
            //         Description ="First News is an international brand of Tri Viet Cultural and Creative " +
            //         "Company, which is one of the most prestigious and popular publishing brands in Vietnam. " +
            //         "Established in 1994, First News has spent 20 years of experience in the field of book " +
            //         "publishing, with over 2,000 valuable books released to readers in all different fields.",
            //         IsDeleted = false
            //     },
            //     new Publisher
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "HarperCollins",
            //         Description ="HarperCollins is another Big 5 publisher, though its 2018 revenue was lower " +
            //         "than PRH’s and Hachette’s at roughly $1.5 billion. HarperCollins was created in 1989 through " +
            //         "a multi-company merger, taking its name from former publishing giants Harper & Row and " +
            //         "William Collins.",
            //         IsDeleted = false
            //     }
            //};

            // var author1 = new Author
            // {
            //     Id = Guid.NewGuid(),
            //     Name = "J. K. Rowling",
            //     Description = "Born in Yate, Gloucestershire, Rowling was working as a researcher and bilingual " +
            //     "secretary for Amnesty International in 1990 when she conceived the idea for the Harry Potter " +
            //     "series while on a delayed train from Manchester to London. The seven-year period that " +
            //     "followed saw the death of her mother, birth of her first child, divorce from her first husband, " +
            //     "and relative poverty until the first novel in the series, Harry Potter and the Philosopher's Stone, " +
            //     "was published in 1997. There were six sequels, of which the last was released in 2007",
            //     IsDeleted = false
            // };

            // var author2 = new Author
            // {
            //     Id = Guid.NewGuid(),
            //     Name = "Dale Carnegie",
            //     Description = "Dale Carnegie (spelled Carnagey until c. 1922; November 24, 1888 – November 1, 1955)" +
            //     " was an American writer and lecturer, and the developer of courses in self-improvement, salesmanship, " +
            //     "corporate training, public speaking, and interpersonal skills. Born into poverty on a farm in Missouri, " +
            //     "he was the author of How to Win Friends and Influence People (1936), a bestseller that remains popular " +
            //     "today. He also wrote How to Stop Worrying and Start Living (1948), Lincoln the Unknown (1932), and several other books.",
            //     IsDeleted = false
            // };
            // var author3 = new Author
            // {
            //     Id = Guid.NewGuid(),
            //     Name = "Aoyama Gosho",
            //     Description = "Gosho Aoyama (born June 21, 1963) " +
            //     "is a Japanese manga artist best known for his manga series Detective Conan (1994–present), known " +
            //     "as Case Closed in some English-speaking countries. As of 2017, his various manga series had a " +
            //     "combined 200 million copies in print worldwide.",
            //     IsDeleted = false
            // };
            // var author4 = new Author
            // {
            //     Id = Guid.NewGuid(),
            //     Name = "Fujiko.F.Fujio",
            //     Description = "Fujiko Fujio  was a pen name of a manga writing duo formed by two Japanese " +
            //     "manga artists. Their real names are Hiroshi Fujimoto (Fujimoto Hiroshi, 1933–1996) " +
            //     "and Motoo Abiko (Abiko Motoo, 1934–present). They formed their partnership in 1951, " +
            //     "and used the Fujiko Fujio name from 1954 until dissolution of the partnership in 1987.",
            //     IsDeleted = false
            // };

            // var books = new List<Book>
            // {
            //     new Book()
            //     {
            //         Id = Guid.NewGuid(),
            //         Title = "The princess and the goblin",
            //         Summary = "A little princess is protected by her friend Curdie and her newly-discovered " +
            //         "great-great-grandmother from the goblin miners who live in caves beneath the royal castle. " +
            //         "One night Princess Irene discovers her beautiful great-great-grandmother spinning silver " +
            //         "thread in the palace tower. Though great danger is about to come upon the sunny kingdom, " +
            //         "the old lady promises to keep Irene safe. But when no one will believe her tales of the " +
            //         "secret tower, Irene's confidence begins to waver",
            //         ImageUrl = "book-01.jpg",
            //         Price = 169000M,
            //         CreatedDate = new DateTimeOffset(2004,07,26,0,0,0, new TimeSpan()),
            //         ModifiedDate = new DateTimeOffset(2004,07,25,0,0,0, new TimeSpan()),
            //         IsActive = false,
            //         Quantity = 52,
            //         Category = categories.Single(c=>c.Name == categories[0].Name),
            //         Publisher = publishers.Single(p=>p.Name == publishers[0].Name),
            //         Authors= new List<Author>{author1, author4}
            //     },
            //     new Book()
            //     {
            //         Id = Guid.NewGuid(),
            //         Title = "L'assommoir",
            //         Summary = "L'Assommoir is a study of alcoholism and poverty in the working-class districts of Paris " +
            //         "Gervaise Macquart, who is featured briefly in the first novel in the series, La Fortune des Rougon, " +
            //         "is running away to Paris with her shiftless lover Lantier to work as a washerwoman in a hot, busy laundry",
            //         ImageUrl = "book-02.jpg",
            //         Price = 10000M,
            //         CreatedDate = new DateTimeOffset(2005,07,26,0,0,0, new TimeSpan()),
            //         ModifiedDate = new DateTimeOffset(2005,07,25,0,0,0, new TimeSpan()),
            //         IsActive = false,
            //         Quantity = 60,
            //         Category = categories.Single(c=>c.Name == categories[1].Name),
            //         Publisher = publishers.Single(p=>p.Name== publishers[1].Name),
            //         Authors= new List<Author>{author1 ,author4}
            //     },

            //     new Book()
            //     {
            //         Id = Guid.NewGuid(),
            //          Title = "The countess de Charny",
            //         Summary = "Ceux de nos excellents lecteurs qui se sont en quelque sorte infeodes a nous ; ceux " +
            //         "qui nous suivent partout ou nous allons ; ceux pour lesquels il est curieux de ne jamais abandonner, " +
            //         "meme dans ses ecarts, un homme qui, comme nous, a entrepris cette tache curieuse de derouler feuille " +
            //         "a feuille chacune des pages de la monarchie",
            //         ImageUrl = "book-03.jpg",
            //         Price = 13000M,
            //         CreatedDate = new DateTimeOffset(2006,07,26,0,0,0, new TimeSpan()),
            //         ModifiedDate = new DateTimeOffset(2006,07,25,0,0,0, new TimeSpan()),
            //         IsActive = false,
            //         Quantity = 80,
            //         Category = categories.Single(c=>c.Name == categories[2].Name),
            //         Publisher = publishers.Single(p=>p.Name == publishers[2].Name),
            //         Authors= new List<Author>{author1, author3,author2}
            //      },
            //      new Book()
            //      {
            //         Id = Guid.NewGuid(),
            //         Title = "Are You My Mother",
            //         Summary = "I play by the rules, but they're my rules.' Poppy Silverton is as untouched as the leafy " +
            //         "English village where she runs a tearoom. But her home, her livelihood and her innocence are under " +
            //         "threat ... . Rafe Caffarelli is a mouthwatering specimen of Mediterranean manhood.",
            //         ImageUrl = "book-04.jpg",
            //         Price = 12000M,
            //         CreatedDate = new DateTimeOffset(2006,07,26,0,0,0, new TimeSpan()),
            //         ModifiedDate = new DateTimeOffset(2006,07,25,0,0,0, new TimeSpan()),
            //         IsActive = false,
            //         Quantity = 50,
            //         Category = categories.Single(c=>c.Name == categories[3].Name),
            //         Publisher = publishers.Single(p=>p.Name == publishers[3].Name),
            //         Authors= new List<Author>{author2}
            //      },
            //      new Book()
            //      {
            //          Id = Guid.NewGuid(),
            //          Title = "Never say no to a Caffarelli",
            //         Summary = "I play by the rules, but they're my rules.' Poppy Silverton is as untouched as the leafy " +
            //         "English village where she runs a tearoom. But her home, her livelihood and her innocence are under " +
            //         "threat ... . Rafe Caffarelli is a mouthwatering specimen of Mediterranean manhood.",
            //         ImageUrl = "book-05.jpg",
            //         Price = 169000M,
            //         CreatedDate = new DateTimeOffset(2004,07,26,0,0,0, new TimeSpan()),
            //         ModifiedDate = new DateTimeOffset(2004,07,25,0,0,0, new TimeSpan()),
            //         IsActive = false,
            //         Quantity = 70,
            //         Category = categories.Single(c=>c.Name == categories[0].Name),
            //         Publisher = publishers.Single(p=>p.Name == publishers[0].Name),
            //         Authors= new List<Author>{author4}
            //      }
            // };
            var categories = new Category[]
            {
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Literary Fiction",
                    Description ="Literary Fiction is often indirect in their theme and includes some kind of analysis on what it means to be human." +
                    "George Orwell’s 1984 is a classic example of literary fiction.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "General Fiction",
                    Description ="These books are easily appealing stories in a contemporary setting." +
                    "They’re more approachable than Literary Fiction and contain none of the genre-specific ingredients that the other categories rely on.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Romance",
                    Description ="Book where the main character or characters fall in love.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Mystery or Suspense",
                    Description ="A book where the story includes the main characters working out why something" +
                    " has happened or will happen in the future.",
                    IsDeleted = false
                }
            };

            var publishers = new Publisher[]
           {
                new Publisher
                {
                    Id = Guid.NewGuid(),
                    Name = "Penguin Random House",
                    Description ="It has over 200 divisions and imprints, in addition to those listed above." +
                    " In terms of actual publishing stats, PRH puts out over 15,000 books a year and sells about" +
                    " 800 million copies of print, audio, and ebooks annually.",
                    IsDeleted = false
                },
                new Publisher
                {
                    Id = Guid.NewGuid(),
                    Name = "Hachette Livre",
                    Description ="Hachette Livre is another Big 5 publisher, the largest in France and one of the most" +
                    " prominent publishers in all of Europe.",
                    IsDeleted = false
                },
                new Publisher
                {
                    Id = Guid.NewGuid(),
                    Name = "HarperCollins",
                    Description ="HarperCollins is another Big 5 publisher, though its 2018 revenue was lower than " +
                    "PRH’s and Hachette’s at roughly $1.5 billion.",
                    IsDeleted = false
                }
           };

            var author1 = new Author
            {
                Id = Guid.NewGuid(),
                Name = "Philip Roth",
                Description = "Philip Milton Roth (March 19, 1933 – May 22, 2018)[1] was an American novelist and short story writer.",
                IsDeleted = false
            };

            var author2 = new Author
            {
                Id = Guid.NewGuid(),
                Name = "Erica Jong",
                Description = "Erica Jong is an American novelist, satirist, and poet, known particularly for her 1973 " +
                "novel Fear of Flying. The book became famously controversial for its attitudes towards female sexuality" +
                " and figured prominently in the development of second-wave feminism.",
                IsDeleted = false
            };
            var author3 = new Author
            {
                Id = Guid.NewGuid(),
                Name = "Paul Kalanithi",
                Description = "Paul Sudhir Arul Kalanithi (April 1, 1977 – March 9, 2015) was an American neurosurgeon " +
                "and writer. His book When Breath Becomes Air is a memoir about his life and illness with stage IV " +
                "metastatic lung cancer. ",
                IsDeleted = false
            };
            var author4 = new Author
            {
                Id = Guid.NewGuid(),
                Name = "Mark Twain",
                Description = "Twain was raised in Hannibal, Missouri, which later provided the setting for Tom Sawyer" +
                " and Huckleberry Finn. He served an apprenticeship with a printer and then worked as a typesetter," +
                " contributing articles to the newspaper of his older brother Orion Clemens. ",
                IsDeleted = false
            };

            var books = new List<Book>
            {
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Title = "Letting Go",
                    Summary = "My dad gave me the novel Letting Go by Philip Roth. Dad read very little fiction—only" +
                    " one book of fiction a year. ",
                    ImageUrl = "book-01.jpg",
                    Price = 169000M,
                    CreatedDate = new DateTimeOffset(2004,07,26,0,0,0, new TimeSpan()),
                    ModifiedDate = new DateTimeOffset(2004,07,25,0,0,0, new TimeSpan()),
                    IsActive = false,
                    Quantity = 52,
                    Category = categories.Single(c=>c.Name==("Literary Fiction")),
                    Publisher = publishers.Single(p=>p.Name==("HarperCollins")),
                    Authors= new List<Author>{author1, author3,author4}
                },
                new Book()
                {
                    Id = Guid.NewGuid(),
                    Title = "Erica Jong’s Fear of Flying",
                    Summary = "Knowing it is my favorite book, for my 34th birthday, a boyfriend once gave me a signed" +
                    " first edition of Erica Jong’s Fear of Flying.",
                    ImageUrl = "book-02.jpg",
                    Price = 10000M,
                    CreatedDate = new DateTimeOffset(2005,07,26,0,0,0, new TimeSpan()),
                    ModifiedDate = new DateTimeOffset(2005,07,25,0,0,0, new TimeSpan()),
                    IsActive = false,
                    Quantity = 60,
                    Category = categories.Single(c=>c.Name==("Literary Fiction")),
                    Publisher = publishers.Single(p=>p.Name==("Hachette Livre")),
                    Authors= new List<Author>{author1, author2,author4}
                },

                new Book()
                {
                    Id = Guid.NewGuid(),
                     Title = "When Breath Becomes Air",
                    Summary = "When Breath Becomes Air by Paul Kalanithi. Kalanithi’s brave memoir chronicles in " +
                    "exquisite prose his brave battle with terminal illness, but rather than verge into depressing" +
                    " territory, it is a triumphant and inspiring read. ",
                    ImageUrl = "book-03.jpg",
                    Price = 13000M,
                    CreatedDate = new DateTimeOffset(2006,07,26,0,0,0, new TimeSpan()),
                    ModifiedDate = new DateTimeOffset(2006,07,25,0,0,0, new TimeSpan()),
                    IsActive = false,
                    Quantity = 80,
                    Category = categories.Single(c=>c.Name==("Mystery or Suspense")),
                    Publisher = publishers.Single(p=>p.Name==("Hachette Livre")),
                    Authors= new List<Author>{author1, author3,author2}
                 },
                 new Book()
                 {
                     Id = Guid.NewGuid(),
                     Title = "The Adventures of Tom Sawyer",
                    Summary = "On my eighth birthday my mother gave me a hardcover copy of The Adventures of Tom Sawyer." +
                    " The inscription read: ‘Here is the brother you said you wanted.’ I was having trouble in" +
                    " school—particularly reading",
                    ImageUrl = "book-04.jpg",
                    Price = 12000M,
                    CreatedDate = new DateTimeOffset(2006,07,26,0,0,0, new TimeSpan()),
                    ModifiedDate = new DateTimeOffset(2006,07,25,0,0,0, new TimeSpan()),
                    IsActive = false,
                    Quantity = 50,
                    Category = categories.Single(c=>c.Name==("Mystery or Suspense")),
                    Publisher = publishers.Single(p=>p.Name==("Hachette Livre")),
                    Authors= new List<Author>{author1, author3,author2}
                 },
                 new Book()
                 {
                     Id = Guid.NewGuid(),
                     Title = "Letting Go",
                    Summary = "My dad gave me the novel Letting Go by Philip Roth. Dad read very little fiction—only" +
                    " one book of fiction a year. ",
                    ImageUrl = "book-05.jpg",
                    Price = 169000M,
                    CreatedDate = new DateTimeOffset(2004,07,26,0,0,0, new TimeSpan()),
                    ModifiedDate = new DateTimeOffset(2004,07,25,0,0,0, new TimeSpan()),
                    IsActive = false,
                    Quantity = 70,
                    Category = categories.Single(c=>c.Name==("Mystery or Suspense")),
                    Publisher = publishers.Single(p=>p.Name==("HarperCollins")),
                    Authors= new List<Author>{author2, author3,author4}
                 }
            };
            context.Categories.AddRange(categories);
            context.Publishers.AddRange(publishers);
            context.Books.AddRange(books);
            context.SaveChanges();
        }

        //Create User=Admin@Admin.com with password=Admin@123456 in the Admin role        
        public static void InitializeIdentity(BookStoreDbContext db)
        {
            var userManager = new UserManager<User>(new UserStore<User>(db));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            const string name = "admin@example.com";
            const string password = "Admin@123456";
            const string roleName = "Admin";

            //Create Role Admin if it does not exist
            var role = roleManager.FindByName(roleName);
            if (role == null)
            {
                role = new IdentityRole(roleName);
                var roleResult = roleManager.Create(role);
            }

            var user = userManager.FindByName(name);
            if (user == null)
            {
                user = new User { UserName = name, Email = name };
                var result = userManager.Create(user, password);
                result = userManager.SetLockoutEnabled(user.Id, false);
            }

            // Add user admin to Role Admin if not already added
            var rolesForUser = userManager.GetRoles(user.Id);
            if (!rolesForUser.Contains(role.Name))
            {
                var result = userManager.AddToRole(user.Id, role.Name);
            }
        }
    }
}
