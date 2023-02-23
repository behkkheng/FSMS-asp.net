using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSMS_asp.net.Models;
using FSMS_asp.net.Models.Quotation;
using Microsoft.AspNetCore.Identity;
using System.Security;
using System.Net;

namespace FSMS_asp.net.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CustomersModel>? CustomersModel { get; set; }
        public DbSet<ProductsModel>? ProductsModel { get; set; }
        public DbSet<InvoicesModel>? InvoicesModel { get; set; }

        public DbSet<InvoiceDetailsModel>? InvoiceDetailsModel { get; set; }

        public DbSet<FSMS_asp.net.Models.Quotation.QuotationsModel> QuotationsModel { get; set; }

        public DbSet<FSMS_asp.net.Models.Quotation.QuotationDetailsModel> QuotationDetailsModel { get; set; }

        public DbSet<FSMS_asp.net.Models.Delivery_Order.DOrdersModel> DOrdersModel { get; set; }

        public DbSet<FSMS_asp.net.Models.Delivery_Order.DOrderDetailsModel> DOrderDetailsModel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CustomersModel>().HasData(
                new CustomersModel
                {
                    Id = 1,
                    Name = "Astarte Myrto",
                    HpNo = "6072363232",
                    Email = "astarte@gmail.com",
                    Address = "6-3C, Jalan Menglembu, 5680, Ipoh, Perak"
                },

                new CustomersModel
                {
                    Id = 2,
                    Name = "Cecil Bors",
                    HpNo = "0392813077",
                    Email = "cecil@gmail.com",
                    Address = "B2-2-4, Jalan Ong Yi How, Taman Jaya, 23400, Perak"
                }
            );

            builder.Entity<ProductsModel>().HasData(
                new ProductsModel
                {
                    Id = 1,
                    Name = "Sofa",
                    Description = "A red sofa.",
                    Price = 123.89m,
                    Quantity = 60,
                    Image = "/images/Products Image/39d427a1-6d30-4fc5-b475-4e2c2cfd8854_sofa.jpg",
                    UpdatedBy = "staff@gmail.com"
                },

                new ProductsModel
                {
                    Id = 2,
                    Name = "Writing Table",
                    Description = "A plastic white table.",
                    Price = 200.50m,
                    Quantity = 140,
                    Image = "/images/Products Image/e3ead3a0-e85f-4346-8fab-6d801ecf60f0_foldable-rectangular-table-n-metal-leg.jpg",
                    UpdatedBy = "staff@gmail.com"
                },

                new ProductsModel
                {
                    Id = 3,
                    Name = "Writing Table",
                    Description = "A plastic white table.",
                    Price = 50.20m,
                    Quantity = 4,
                    Image = "/images/Products Image/e174a37f-304f-491d-9f7a-73bfdf5244de_plasticchair.jpg",
                    UpdatedBy = "staff@gmail.com"
                }
            );

            var hasher = new PasswordHasher<IdentityUser>();

            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "40352054-6ef4-4be4-8c4f-b3a216bba268",
                    Name = "Staff",
                    Email = "staff@gmail.com",
                    UserName = "staff@gmail.com",
                    NormalizedUserName = "STAFF@GMAIL.COM",
                    NormalizedEmail = "STAFF@GMAIL.COM",
                    PhoneNumber = "0176740394",
                    SecurityStamp = "a5accac9-9b1a-453c-b9e0-0793a418f46d",
                    ConcurrencyStamp = "f055c0fe-6bb1-4295-b86c-ec05780c2f47",
                    Address = "343, Taman Bistari Jaya, 19800, Perak",
                    PasswordHash = hasher.HashPassword(null, "qqqq")
                },

                new ApplicationUser
                {
                    Id = "45eeeec2-99b2-4115-9d96-481c08bcf984",
                    Name = "Manager",
                    Email = "manager@gmail.com",
                    UserName = "manager@gmail.com",
                    NormalizedUserName = "MANAGER@GMAIL.COM",
                    NormalizedEmail = "MANAGER@GMAIL.COM",
                    PhoneNumber = "0192045656",
                    SecurityStamp = "227ec267-6ac4-453b-9eff-4b653aaaacd6",
                    ConcurrencyStamp = "33d137c6-40c0-45c4-9f8e-fc94d573f3d5",
                    Address = "22A, Taman Bagan, 36700, Penang",
                    PasswordHash = hasher.HashPassword(null, "qqqq")
                }
            );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "9b88addd-d4bf-4ea5-b777-70753617f2e9",
                    Name = "Staff",
                    NormalizedName = "STAFF",
                    ConcurrencyStamp = "a415be2c-4241-4ec4-9a56-11212bf1edf1",
                },

                new IdentityRole
                {
                    Id = "35ad3cc4-b118-416b-881c-37ff6de075bf",
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    ConcurrencyStamp = "786ca1ca-0e96-4b85-b438-d300b5488e99",
                }
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "9b88addd-d4bf-4ea5-b777-70753617f2e9",
                    UserId = "40352054-6ef4-4be4-8c4f-b3a216bba268",
                },

                new IdentityUserRole<string>
                {
                    RoleId = "35ad3cc4-b118-416b-881c-37ff6de075bf",
                    UserId = "45eeeec2-99b2-4115-9d96-481c08bcf984",
                }
            );
        }
    }
}