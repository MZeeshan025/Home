using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Zeeshan_Proj.Models
{
    public class DBContextModel: DbContext
    {
        public DBContextModel(DbContextOptions<DBContextModel> options) : base(options)
        {

        }
        public DbSet<DataModel> DataModels { get; set; }
    }
}
