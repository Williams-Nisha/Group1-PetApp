using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PetApp.Models;

namespace PetApp.Migrations
{
    [DbContext(typeof(PetAppContext))]
    partial class PetAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetApp.Models.Pet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnimalCategory");

                    b.Property<string>("AnimalName");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Breed");

                    b.Property<string>("OwnerCity");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerPhoneNum");

                    b.Property<string>("OwnerState");

                    b.Property<string>("OwnerStreet");

                    b.Property<string>("OwnerZip");

                    b.Property<string>("PhotoUrl");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("SerialNum");

                    b.HasKey("ID");

                    b.ToTable("Pet");
                });
        }
    }
}
