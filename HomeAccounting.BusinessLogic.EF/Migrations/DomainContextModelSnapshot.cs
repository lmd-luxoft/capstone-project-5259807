// <auto-generated />
using System;
using HomeAccounting.BusinessLogic.EF.AppLogic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeAccounting.BusinessLogic.EF.Migrations
{
    [DbContext(typeof(DomainContext))]
    partial class DomainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("OperationId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OperationId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Bank", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorrespondetAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Operation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ExecutionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Operations");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.PropertyChange", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Delta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("PropertyId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("PropertyChanges");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Cash", b =>
                {
                    b.HasBaseType("HomeAccounting.BusinessLogic.EF.Domain.Account");

                    b.Property<int>("Banknotes")
                        .HasColumnType("int");

                    b.Property<int>("Monets")
                        .HasColumnType("int");

                    b.ToTable("Cashes");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Deposit", b =>
                {
                    b.HasBaseType("HomeAccounting.BusinessLogic.EF.Domain.Account");

                    b.Property<long?>("BankId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfBankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Percent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasIndex("BankId");

                    b.ToTable("Deposites");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Property", b =>
                {
                    b.HasBaseType("HomeAccounting.BusinessLogic.EF.Domain.Account");

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Account", b =>
                {
                    b.HasOne("HomeAccounting.BusinessLogic.EF.Domain.Operation", null)
                        .WithMany("Account")
                        .HasForeignKey("OperationId");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.PropertyChange", b =>
                {
                    b.HasOne("HomeAccounting.BusinessLogic.EF.Domain.Property", null)
                        .WithMany("PropertyChange")
                        .HasForeignKey("PropertyId");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Cash", b =>
                {
                    b.HasOne("HomeAccounting.BusinessLogic.EF.Domain.Account", null)
                        .WithOne()
                        .HasForeignKey("HomeAccounting.BusinessLogic.EF.Domain.Cash", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Deposit", b =>
                {
                    b.HasOne("HomeAccounting.BusinessLogic.EF.Domain.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("HomeAccounting.BusinessLogic.EF.Domain.Account", null)
                        .WithOne()
                        .HasForeignKey("HomeAccounting.BusinessLogic.EF.Domain.Deposit", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Property", b =>
                {
                    b.HasOne("HomeAccounting.BusinessLogic.EF.Domain.Account", null)
                        .WithOne()
                        .HasForeignKey("HomeAccounting.BusinessLogic.EF.Domain.Property", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Operation", b =>
                {
                    b.Navigation("Account");
                });

            modelBuilder.Entity("HomeAccounting.BusinessLogic.EF.Domain.Property", b =>
                {
                    b.Navigation("PropertyChange");
                });
#pragma warning restore 612, 618
        }
    }
}
