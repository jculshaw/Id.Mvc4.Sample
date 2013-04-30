using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Id.Mvc4.Sample.Models
{
    public class LibraryInitializer : DropCreateDatabaseIfModelChanges<LibraryEntities>
    {
        protected override void Seed(LibraryEntities context)
        {
            Subject Antiquarian = new Subject() { Name = "Antiquarian, Rare & Collectable" };
            Subject Biography = new Subject() { Name = "Biography" };
            Subject Crime = new Subject() { Name = "Crime, Thrillers & Mystery" };
            Subject History = new Subject() { Name = "History" };
            Subject Horror = new Subject() { Name = "Horror" };
            Subject Romance = new Subject() { Name = "Romance" };
            Subject SciFiAndFantasy = new Subject() { Name = "Science Fiction & Fantasy" };
            Subject Travel = new Subject() { Name = "Travel & Holiday" };

            context.Subjects.Add(Antiquarian);
            context.Subjects.Add(Biography);
            context.Subjects.Add(Crime);
            context.Subjects.Add(History);
            context.Subjects.Add(Horror);
            context.Subjects.Add(Romance);
            context.Subjects.Add(SciFiAndFantasy);
            context.Subjects.Add(Travel);

            Format Hardcover = new Models.Format() { Name = "Hardcover" };
            Format Paperback = new Models.Format() { Name = "Paperback" };
            Format Kindle = new Models.Format() { Name = "Kindle Books" };

            context.Formats.Add(Hardcover);
            context.Formats.Add(Paperback);
            context.Formats.Add(Kindle);

            Author LKHamilton = new Author() { Name = "Laurell K. Hamilton" };
            Author KCast = new Author() { Name = "Kristin Cast" };
            Author PCCast = new Author() { Name = "P. C. Cast" };
            Author RPike = new Author() { Name = "Richard Pike" };
            Author CGibson = new Author() { Name = "Chris Gibson" };
            Author RVincent = new Author() { Name = "Rachel Vincent" };
            Author CHarris = new Author() { Name = "Charlaine Harris" };
            Author JLake = new Author() { Name = "John Lake" };
            Author MStyling = new Author() { Name = "Mark Styling" };
            Author CWSmith = new Author() { Name = "Charles William Smith" };
            Author CTomalin = new Author() { Name = "Claire Tomalin" };
            Author ASugar = new Author() { Name = "Alan Sugar" };
            Author TPratchett = new Author() { Name = "Sir Terry Pratchett" };
            Author REFeist = new Author() { Name = "Raymond E. Feist" };
            Author PIrvine = new Author() { Name = "Peter Irvine" };
            Author DFriebe = new Author() { Name = "Daniel Friebe" };
            Author KDoner = new Author() { Name = "Kim Doner" };

            context.Authors.Add(LKHamilton);
            context.Authors.Add(KCast);
            context.Authors.Add(PCCast);
            context.Authors.Add(RPike);
            context.Authors.Add(CGibson);
            context.Authors.Add(RVincent);
            context.Authors.Add(CHarris);
            context.Authors.Add(JLake);
            context.Authors.Add(MStyling);
            context.Authors.Add(CWSmith);
            context.Authors.Add(CTomalin);
            context.Authors.Add(ASugar);
            context.Authors.Add(TPratchett);
            context.Authors.Add(REFeist);
            context.Authors.Add(PIrvine);
            context.Authors.Add(DFriebe);
            context.Authors.Add(KDoner);

            context.Books.Add(new Book()
            {
                Title = "The Lightning Boys: True Tales from Pilots of the English Electric Lightning",
                Price = 12.25M,
                Isbn = "190811715X",
                PublicationDate = new DateTime(2011, 7, 14),
                Format = Hardcover,
                Subject = History,
                Authors = new List<Author>() { RPike }
            });

            context.Books.Add(new Book()
            {
                Title = "Awakened (House of Night)",
                Price = 4.12M,
                Isbn = "1905654855",
                PublicationDate = new DateTime(2011, 10, 25),
                Format = Paperback,
                Subject = Horror,
                Authors = new List<Author>() { KCast, PCCast }
            });

            context.Books.Add(new Book()
            {
                Title = "Destined: A House of Night Novel",
                Price = 6.49M,
                Isbn = "1905654871",
                PublicationDate = new DateTime(2011, 10, 25),
                Format = Hardcover,
                Subject = Horror,
                Authors = new List<Author>() { KCast, PCCast }
            });

            context.Books.Add(new Book()
            {
                Title = "Dragon's Oath: A House of Night Novella",
                Price = 3.82M,
                Isbn = "1907411186",
                PublicationDate = new DateTime(2011, 7, 12),
                Format = Paperback,
                Subject = Horror,
                Authors = new List<Author>() { KCast, PCCast }
            });

            context.Books.Add(new Book()
            {
                Title = "Dragon's Oath: A House of Night Novella",
                Price = 3.56M,
                Isbn = "1907410708",
                PublicationDate = new DateTime(2010, 10, 26),
                Format = Hardcover,
                Subject = Horror,
                Authors = new List<Author>() { PCCast, KDoner }
            });

            context.Books.Add(new Book()
            {
                Title = "Bullet (Anita Blake, Vampire Hunter)",
                Price = 4.55M,
                Isbn = "0755352580",
                PublicationDate = new DateTime(2010, 11, 11),
                Format = Paperback,
                Subject = Horror,
                Authors = new List<Author>() { LKHamilton }
            });

            context.Books.Add(new Book()
            {
                Title = "Incubus Dreams (Anita Blake Vampire Hunter 12)",
                Price = 4.87M,
                Isbn = "0755355407",
                PublicationDate = new DateTime(2010, 3, 4),
                Format = Paperback,
                Subject = Horror,
                Authors = new List<Author>() { LKHamilton }
            });

            context.Books.Add(new Book()
            {
                Title = "Vulcan's Hammer: V-Force Aircraft and Weapons Projects Since 1945",
                Price = 20.80M,
                Isbn = "1902109171",
                PublicationDate = new DateTime(2011, 4, 30),
                Format = Hardcover,
                Subject = History,
                Authors = new List<Author>() { CGibson }
            });

            context.Books.Add(new Book()
            {
                Title = "Deadlocked: A True Blood Novel",
                Price = 14.24M,
                Isbn = "0575096578",
                PublicationDate = new DateTime(2012, 5, 17),
                Format = Hardcover,
                Subject = Horror,
                Authors = new List<Author>() { CHarris }
            });

            context.Books.Add(new Book()
            {
                Title = "B-52 Stratofortress Units 1955-73",
                Price = 12.99M,
                Isbn = "1841766070",
                PublicationDate = new DateTime(2004, 1, 16),
                Format = Paperback,
                Subject = History,
                Authors = new List<Author>() { JLake, MStyling }
            });

            context.Books.Add(new Book()
            {
                Title = "Abstractions",
                Price = 14517.21M,
                Isbn = "B00085JQEI",
                PublicationDate = new DateTime(1939, 1, 1),
                Format = Hardcover,
                Subject = Antiquarian,
                Authors = new List<Author>() { CWSmith }
            });

            context.Books.Add(new Book()
            {
                Title = "The Way I See It: Rants, Revelations And Rules For Life",
                Price = 8.00M,
                Isbn = "0230760899",
                PublicationDate = new DateTime(2011, 9, 29),
                Format = Hardcover,
                Subject = Biography,
                Authors = new List<Author>() { ASugar }
            });

            context.Books.Add(new Book()
            {
                Title = "The Way I See It: Rants, Revelations And Rules For Life",
                Price = 4.79M,
                Isbn = "0230760899",
                PublicationDate = new DateTime(2011, 9, 29),
                Format = Kindle,
                Subject = Biography,
                Authors = new List<Author>() { ASugar }
            });

            context.Books.Add(new Book()
            {
                Title = "Charles Dickens: A Life",
                Price = 13.50M,
                Isbn = "0670917672",
                PublicationDate = new DateTime(2011, 10, 6),
                Format = Hardcover,
                Subject = Biography,
                Authors = new List<Author>() { CTomalin }
            });

            context.Books.Add(new Book()
            {
                Title = "What You See Is What You Get",
                Price = 4.27M,
                Isbn = "0330520474",
                PublicationDate = new DateTime(2010, 9, 30),
                Format = Kindle,
                Subject = Biography,
                Authors = new List<Author>() { ASugar }
            });

            context.Books.Add(new Book()
            {
                Title = "Snuff: Discworld Novel 39",
                Price = 8.99M,
                Isbn = "038561926X",
                PublicationDate = new DateTime(2011, 10, 13),
                Format = Hardcover,
                Subject = SciFiAndFantasy,
                Authors = new List<Author>() { TPratchett }
            });

            context.Books.Add(new Book()
            {
                Title = "I Shall Wear Midnight: Discworld Novel 38",
                Price = 4.59M,
                Isbn = "0552555592",
                PublicationDate = new DateTime(2011, 6, 9),
                Format = Paperback,
                Subject = SciFiAndFantasy,
                Authors = new List<Author>() { TPratchett }
            });

            context.Books.Add(new Book()
            {
                Title = "I Shall Wear Midnight: Discworld Novel 38",
                Price = 3.99M,
                Isbn = "0552555592",
                PublicationDate = new DateTime(2011, 6, 9),
                Format = Kindle,
                Subject = SciFiAndFantasy,
                Authors = new List<Author>() { TPratchett }
            });

            context.Books.Add(new Book()
            {
                Title = "Magician",
                Price = 5.29M,
                Isbn = "0586217835",
                PublicationDate = new DateTime(2008, 9, 1),
                Format = Paperback,
                Subject = SciFiAndFantasy,
                Authors = new List<Author>() { REFeist }
            });

            context.Books.Add(new Book()
            {
                Title = "Silverthorn",
                Price = 6.74M,
                Isbn = "0007229429",
                PublicationDate = new DateTime(2008, 9, 1),
                Format = Paperback,
                Subject = SciFiAndFantasy,
                Authors = new List<Author>() { REFeist }
            });

            context.Books.Add(new Book()
            {
                Title = "A Darkness at Sethanon",
                Price = 5.29M,
                Isbn = "0007229437",
                PublicationDate = new DateTime(2008, 9, 1),
                Format = Paperback,
                Subject = SciFiAndFantasy,
                Authors = new List<Author>() { REFeist }
            });

            context.Books.Add(new Book()
            {
                Title = "Scotland The Best",
                Price = 9.49M,
                Isbn = "0007442440",
                PublicationDate = new DateTime(2011, 12, 8),
                Format = Paperback,
                Subject = Travel,
                Authors = new List<Author>() { PIrvine }
            });

            context.Books.Add(new Book()
            {
                Title = "Mountain High: Europe's 50 Greatest Cycle Climbs",
                Price = 10.00M,
                Isbn = "0857386247",
                PublicationDate = new DateTime(2011, 10, 27),
                Format = Hardcover,
                Subject = Travel,
                Authors = new List<Author>() { DFriebe }
            });

            context.SaveChanges();

        }
    }
}