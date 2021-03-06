// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MudTestApp.Data;

namespace MudTestApp.Migrations
{
    [DbContext(typeof(MudTestAppContext))]
    [Migration("20220617151622_AddItdentityTables")]
    partial class AddItdentityTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MudTestApp.Models.Compound", b =>
                {
                    b.Property<int>("CompoundID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("C_100Mod")
                        .HasColumnType("int");

                    b.Property<int>("C_25Mod")
                        .HasColumnType("int");

                    b.Property<int>("C_50Mod")
                        .HasColumnType("int");

                    b.Property<int>("C_Elongation")
                        .HasColumnType("int");

                    b.Property<int>("C_Hardness")
                        .HasColumnType("int");

                    b.Property<bool>("C_Production")
                        .HasColumnType("bit");

                    b.Property<int>("C_Tensile")
                        .HasColumnType("int");

                    b.Property<string>("CompoundName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompoundID");

                    b.ToTable("Compound");
                });

            modelBuilder.Entity("MudTestApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MudTestApp.Models.Test", b =>
                {
                    b.Property<int>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateEnded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExposureTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LabTechAssigned")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MudSystemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MudType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TestComments")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("MudTestApp.Models.TestResults", b =>
                {
                    b.Property<int>("TestResultsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompoundID")
                        .HasColumnType("int");

                    b.Property<string>("Observations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("S1Hardness_a")
                        .HasColumnType("float");

                    b.Property<double>("S1Hardness_b")
                        .HasColumnType("float");

                    b.Property<double>("S1Thickness")
                        .HasColumnType("float");

                    b.Property<double>("S1WtAir_a")
                        .HasColumnType("float");

                    b.Property<double>("S1WtAir_b")
                        .HasColumnType("float");

                    b.Property<double>("S1WtWater_a")
                        .HasColumnType("float");

                    b.Property<double>("S1WtWater_b")
                        .HasColumnType("float");

                    b.Property<double>("S1_100Mod")
                        .HasColumnType("float");

                    b.Property<double>("S1_25Mod")
                        .HasColumnType("float");

                    b.Property<double>("S1_50Mod")
                        .HasColumnType("float");

                    b.Property<double>("S1_elongation")
                        .HasColumnType("float");

                    b.Property<double>("S1_tensile")
                        .HasColumnType("float");

                    b.Property<double>("S2Hardness_a")
                        .HasColumnType("float");

                    b.Property<double>("S2Hardness_b")
                        .HasColumnType("float");

                    b.Property<double>("S2Thickness")
                        .HasColumnType("float");

                    b.Property<double>("S2WtAir_a")
                        .HasColumnType("float");

                    b.Property<double>("S2WtAir_b")
                        .HasColumnType("float");

                    b.Property<double>("S2WtWater_a")
                        .HasColumnType("float");

                    b.Property<double>("S2WtWater_b")
                        .HasColumnType("float");

                    b.Property<double>("S2_100Mod")
                        .HasColumnType("float");

                    b.Property<double>("S2_25Mod")
                        .HasColumnType("float");

                    b.Property<double>("S2_50Mod")
                        .HasColumnType("float");

                    b.Property<double>("S2_elongation")
                        .HasColumnType("float");

                    b.Property<double>("S2_tensile")
                        .HasColumnType("float");

                    b.Property<double>("S3Hardness_a")
                        .HasColumnType("float");

                    b.Property<double>("S3Hardness_b")
                        .HasColumnType("float");

                    b.Property<double>("S3Thickness")
                        .HasColumnType("float");

                    b.Property<double>("S3WtAir_a")
                        .HasColumnType("float");

                    b.Property<double>("S3WtAir_b")
                        .HasColumnType("float");

                    b.Property<double>("S3WtWater_a")
                        .HasColumnType("float");

                    b.Property<double>("S3WtWater_b")
                        .HasColumnType("float");

                    b.Property<double>("S3_100Mod")
                        .HasColumnType("float");

                    b.Property<double>("S3_25Mod")
                        .HasColumnType("float");

                    b.Property<double>("S3_50Mod")
                        .HasColumnType("float");

                    b.Property<double>("S3_elongation")
                        .HasColumnType("float");

                    b.Property<double>("S3_tensile")
                        .HasColumnType("float");

                    b.Property<int>("TestID")
                        .HasColumnType("int");

                    b.Property<int>("TestTemp")
                        .HasColumnType("int");

                    b.HasKey("TestResultsID");

                    b.HasIndex("CompoundID");

                    b.HasIndex("TestID");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("MudTestApp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MudTestApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MudTestApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MudTestApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MudTestApp.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MudTestApp.Models.Test", b =>
                {
                    b.HasOne("MudTestApp.Models.Customer", "Customer")
                        .WithMany("Tests")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MudTestApp.Models.TestResults", b =>
                {
                    b.HasOne("MudTestApp.Models.Compound", "Compound")
                        .WithMany("Results")
                        .HasForeignKey("CompoundID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MudTestApp.Models.Test", "Test")
                        .WithMany("Results")
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compound");

                    b.Navigation("Test");
                });

            modelBuilder.Entity("MudTestApp.Models.Compound", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("MudTestApp.Models.Customer", b =>
                {
                    b.Navigation("Tests");
                });

            modelBuilder.Entity("MudTestApp.Models.Test", b =>
                {
                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
