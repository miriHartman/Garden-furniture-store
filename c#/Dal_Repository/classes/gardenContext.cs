using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal_Repository.classes
{
    public partial class gardenContext :DbContext
    {
        public DbSet<Buy> buys { get; set; }
        public DbSet<Buy_Detailes> buys_detailes { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Company> companies { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer("Server=DESKTOP-L9S4R74;Database=myGardenNew;Trusted_Connection=True;TrustServerCertificate=True");



    }
}
