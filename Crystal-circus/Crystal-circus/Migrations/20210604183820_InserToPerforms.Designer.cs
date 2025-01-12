﻿// <auto-generated />
using Crystal_circus.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Crystal_circus.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210604183820_InserToPerforms")]
    partial class InserToPerforms
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Crystal_circus.Models.CreditcardModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CVCNumber")
                        .HasColumnType("int");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("text");

                    b.Property<string>("HolderName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Creditcards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CVCNumber = 178,
                            CardNumber = 518674827,
                            Date = "07/23",
                            HolderName = "hanan"
                        },
                        new
                        {
                            Id = 2,
                            CVCNumber = 602,
                            CardNumber = 518624197,
                            Date = "11/21",
                            HolderName = "areej"
                        },
                        new
                        {
                            Id = 3,
                            CVCNumber = 402,
                            CardNumber = 518602356,
                            Date = "03/22",
                            HolderName = "aryam"
                        });
                });

            modelBuilder.Entity("Crystal_circus.Models.PerformerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Profession")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Performers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://www.cirquedusoleil.com/-/media/cds/images/shows/luzia/luzia-highlights/luzia_highlights_canes_1280x853.jpg?db=web&h=853&la=en&vs=1&w=1280&hash=AFCA94652F959A82CDD8D162F70A0BBE2B03813E",
                            Name = "Cirque du Soleil",
                            PhoneNumber = 89357743,
                            Profession = "Broadway"
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://dynaimage.cdn.cnn.com/cnn/c_fill,g_auto,w_1200,h_675,ar_16:9/https%3A%2F%2Fcdn.cnn.com%2Fcnnnext%2Fdam%2Fassets%2F200629130029-cirque-du-soleil-bankrupt.jpg",
                            Name = "Reema the clown",
                            PhoneNumber = 5628285,
                            Profession = "Clown"
                        });
                });

            modelBuilder.Entity("Crystal_circus.Models.ShowModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Time")
                        .HasColumnType("text");

                    b.Property<int>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VenueId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("Crystal_circus.Models.ShowPerformerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PerformerId")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerformerId");

                    b.HasIndex("ShowId");

                    b.ToTable("ShowPerformerModel");
                });

            modelBuilder.Entity("Crystal_circus.Models.TicketModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Crystal_circus.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreditcardId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreditcardId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreditcardId = 1,
                            Email = "han@example.com",
                            Name = "hanan",
                            PhoneNumber = 5539572
                        },
                        new
                        {
                            Id = 2,
                            CreditcardId = 2,
                            Email = "ali@example.com",
                            Name = "ali",
                            PhoneNumber = 5012372
                        },
                        new
                        {
                            Id = 3,
                            CreditcardId = 3,
                            Email = "lay@example.com",
                            Name = "layla",
                            PhoneNumber = 5645339
                        });
                });

            modelBuilder.Entity("Crystal_circus.Models.VenueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Zag, Hanover, Germany",
                            Image = "https://www.eventim.de/obj/media/DE-eventim/teaser/artworks/2019/young-stage-int-circus-festival-tickets-artwork-2020.jpg",
                            Type = "Arena"
                        },
                        new
                        {
                            Id = 2,
                            Address = "QUARTERBACK Immobilien, Leipzig, Germany",
                            Image = "https://www.quarterback-immobilien-arena.de/fileadmin/files/_processed_/7/2/csm_03_Tempete_The_Fall-4404_Credit_Cirque_du_Soleil_44bc978214.jpg",
                            Type = "Arena"
                        });
                });

            modelBuilder.Entity("Crystal_circus.Models.ShowModel", b =>
                {
                    b.HasOne("Crystal_circus.Models.VenueModel", "Venue")
                        .WithMany("Shows")
                        .HasForeignKey("VenueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Crystal_circus.Models.ShowPerformerModel", b =>
                {
                    b.HasOne("Crystal_circus.Models.PerformerModel", "Performer")
                        .WithMany("ShowPerformer")
                        .HasForeignKey("PerformerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crystal_circus.Models.ShowModel", "Show")
                        .WithMany("ShowPerformer")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Crystal_circus.Models.TicketModel", b =>
                {
                    b.HasOne("Crystal_circus.Models.ShowModel", "Show")
                        .WithMany()
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Crystal_circus.Models.UserModel", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Crystal_circus.Models.UserModel", b =>
                {
                    b.HasOne("Crystal_circus.Models.CreditcardModel", "Creditcard")
                        .WithMany()
                        .HasForeignKey("CreditcardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
