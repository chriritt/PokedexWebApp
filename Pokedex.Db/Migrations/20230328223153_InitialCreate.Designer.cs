﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokedex.Db.Repository;

#nullable disable

namespace Pokedex.Db.Migrations
{
    [DbContext(typeof(PokedexContext))]
    [Migration("20230328223153_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Pokedex.Db.Entities.CaughtPokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CaughtPokemon");
                });

            modelBuilder.Entity("Pokedex.Db.Entities.PokemonTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ability")
                        .HasColumnType("TEXT");

                    b.Property<string>("HeldItems")
                        .HasColumnType("TEXT");

                    b.Property<string>("Move1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Move2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Move3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Move4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nature")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sprite")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeamId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Pokemans");
                });

            modelBuilder.Entity("Pokedex.Db.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Pokedex.Db.Entities.PokemonTeam", b =>
                {
                    b.HasOne("Pokedex.Db.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
