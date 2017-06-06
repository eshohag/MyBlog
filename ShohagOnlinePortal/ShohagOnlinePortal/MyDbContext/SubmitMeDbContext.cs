using ShohagOnlinePortal.Models;
using System.Data.Entity;

namespace ShohagOnlinePortal.MyDbContext
{
    public class SubmitMeDbContext : DbContext
    {
        public SubmitMeDbContext() : base("MyPersonalDatabase")
        {

        }

        public DbSet<SubmitMeContact> SubmitMeContacts { get; set; }

    }
}