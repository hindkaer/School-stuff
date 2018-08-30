using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // Create and save a new Blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Create and save a new Organization
                Console.Write("Enter a name for a new Organization: ");
                var organizationname = Console.ReadLine();

                var organization = new Organization { OrganizationName = organizationname };
                db.Organizations.Add(organization);
                db.SaveChanges();

                Console.WriteLine();

                // Display all Blogs from the database
                var query = from b in db.Blogs
                    orderby b.Name
                    select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine();
                // Display all Organizations from the database
                var query1 = from o in db.Organizations
                    orderby o.OrganizationName
                    select o;

                Console.WriteLine("All organizations in the database:");
                foreach (var item in query1)
                {
                    Console.WriteLine(item.OrganizationName);
                }
                Console.WriteLine();

                // Create and save a new User, linked to organization
                Console.Write("Enter a name for a new User, who is linked with the organization: ");
                var username = Console.ReadLine();

                var user = new User { Username = username , Organization = organization};
                db.Users.Add(user);
                db.SaveChanges();

                // Display the user linked to the organization
                var query2 = from u in db.Users
                    orderby u.Username
                    select u;

                foreach (var item in query2)
                {
                    Console.WriteLine("The user {0} is linked to the organization: {1}", item.Username, item.Organization.OrganizationName);
                }
            }
        }
    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }

        public virtual Organization Organization { get; set; }
    }

    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("display_name");
        }
    }

    public class Organization 
    {
        public int OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public virtual List<Country> HomeLands { get; set; }
    }

    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int CountryCode { get; set; }
        public virtual List<Organization> OrgsInCountry { get; set; }

    }
}
