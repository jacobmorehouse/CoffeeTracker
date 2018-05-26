﻿// <auto-generated />
using CoffeeTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoffeeTracker.Migrations
{
    [DbContext(typeof(CoffeeTrackerContext))]
    partial class CoffeeTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeeTracker.Models.Coffee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("CEU");

                    b.Property<DateTime>("consumed");

                    b.Property<bool>("iced");

                    b.Property<DateTime>("recorded");

                    b.HasKey("ID");

                    b.ToTable("Coffee");
                });
#pragma warning restore 612, 618
        }
    }
}
