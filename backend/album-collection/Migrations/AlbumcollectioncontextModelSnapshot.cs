﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using album_collection.Models;

namespace album_collection.Migrations
{
    [DbContext(typeof(Albumcollectioncontext))]
    partial class AlbumcollectioncontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            Image = "img",
                            RecordLabel = "columbia records",
                            Title = "Lock and Key"
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            Image = "img",
                            RecordLabel = "columbia records",
                            Title = "Artist A Album"
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            Image = "img",
                            RecordLabel = "columbia records",
                            Title = "Artist B Album"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("HomeTown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecordLabel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 25,
                            HomeTown = "atlanta",
                            Image = "img",
                            Name = "Usher",
                            RecordLabel = "columbia records"
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            HomeTown = "chicago",
                            Image = "img",
                            Name = "Artist A",
                            RecordLabel = "columbia records"
                        },
                        new
                        {
                            Id = 3,
                            Age = 25,
                            HomeTown = "cleveland",
                            Image = "img",
                            Name = "Artist B",
                            RecordLabel = "columbia records"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Confessions"
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Confessions Part 2"
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 1,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Confessions Part 3"
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 2,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Song A-1"
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 2,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Song A-2"
                        },
                        new
                        {
                            Id = 6,
                            AlbumId = 2,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Song A-3"
                        },
                        new
                        {
                            Id = 7,
                            AlbumId = 3,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Song B-1"
                        },
                        new
                        {
                            Id = 8,
                            AlbumId = 3,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Song B-2"
                        },
                        new
                        {
                            Id = 9,
                            AlbumId = 3,
                            Duration = "3:12",
                            Link = "song.com",
                            Title = "Song B-3"
                        });
                });

            modelBuilder.Entity("album_collection.Models.Album", b =>
                {
                    b.HasOne("album_collection.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("album_collection.Models.Song", b =>
                {
                    b.HasOne("album_collection.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
