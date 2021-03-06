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
    [Migration("20220607145734_computedCol_test")]
    partial class computedCol_test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<double>("HardnessChange")
                        .HasColumnType("float");

                    b.Property<double>("Hardness_After_Avg")
                        .HasColumnType("float");

                    b.Property<double>("Hardness_Before_Avg")
                        .HasColumnType("float");

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

                    b.Property<int>("S1_100Mod")
                        .HasColumnType("int");

                    b.Property<int>("S1_25Mod")
                        .HasColumnType("int");

                    b.Property<int>("S1_50Mod")
                        .HasColumnType("int");

                    b.Property<int>("S1_elongation")
                        .HasColumnType("int");

                    b.Property<int>("S1_tensile")
                        .HasColumnType("int");

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

                    b.Property<int>("S2_100Mod")
                        .HasColumnType("int");

                    b.Property<int>("S2_25Mod")
                        .HasColumnType("int");

                    b.Property<int>("S2_50Mod")
                        .HasColumnType("int");

                    b.Property<int>("S2_elongation")
                        .HasColumnType("int");

                    b.Property<int>("S2_tensile")
                        .HasColumnType("int");

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

                    b.Property<int>("S3_100Mod")
                        .HasColumnType("int");

                    b.Property<int>("S3_25Mod")
                        .HasColumnType("int");

                    b.Property<int>("S3_50Mod")
                        .HasColumnType("int");

                    b.Property<int>("S3_elongation")
                        .HasColumnType("int");

                    b.Property<int>("S3_tensile")
                        .HasColumnType("int");

                    b.Property<int>("TestID")
                        .HasColumnType("int");

                    b.Property<int>("TestTemp")
                        .HasColumnType("int");

                    b.HasKey("TestResultsID");

                    b.HasIndex("CompoundID");

                    b.HasIndex("TestID");

                    b.ToTable("TestResults");
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
