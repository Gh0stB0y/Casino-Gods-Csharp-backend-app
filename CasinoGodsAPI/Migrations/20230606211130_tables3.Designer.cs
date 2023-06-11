﻿// <auto-generated />
using System;
using CasinoGodsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CasinoGodsAPI.Migrations
{
    [DbContext(typeof(CasinoGodsDbContext))]
    [Migration("20230606211130_tables3")]
    partial class tables3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CasinoGodsAPI.Models.Dealer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<float>("profit")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Dealers");
                });

            modelBuilder.Entity("CasinoGodsAPI.Models.GamePlusPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("draws")
                        .HasColumnType("int");

                    b.Property<string>("gameNameName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("gamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("loses")
                        .HasColumnType("int");

                    b.Property<Guid?>("playerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("profit")
                        .HasColumnType("real");

                    b.Property<float>("winratio")
                        .HasColumnType("real");

                    b.Property<int>("wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("gameNameName");

                    b.HasIndex("playerId");

                    b.ToTable("GamePlusPlayersTable");
                });

            modelBuilder.Entity("CasinoGodsAPI.Models.GamesDatabase", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("GamesList");
                });

            modelBuilder.Entity("CasinoGodsAPI.Models.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("bankroll")
                        .HasColumnType("int");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("passHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("passSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("profit")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("CasinoGodsAPI.TablesModel.BlackjackTablesDatabase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("actionTime")
                        .HasColumnType("int");

                    b.Property<int>("decks")
                        .HasColumnType("int");

                    b.Property<int>("seatsCount")
                        .HasColumnType("int");

                    b.Property<bool>("sidebet1")
                        .HasColumnType("bit");

                    b.Property<bool>("sidebet2")
                        .HasColumnType("bit");

                    b.Property<string>("tablename")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("tablename");

                    b.ToTable("MyBlackJackTables");
                });

            modelBuilder.Entity("CasinoGodsAPI.TablesModel.TablesDatabase", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<int>("betTime")
                        .HasColumnType("int");

                    b.Property<string>("gameName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("maxBet")
                        .HasColumnType("int");

                    b.Property<int>("minBet")
                        .HasColumnType("int");

                    b.HasKey("name");

                    b.HasIndex("gameName");

                    b.ToTable("TablesList");
                });

            modelBuilder.Entity("CasinoGodsAPI.Models.GamePlusPlayer", b =>
                {
                    b.HasOne("CasinoGodsAPI.Models.GamesDatabase", "gameName")
                        .WithMany()
                        .HasForeignKey("gameNameName");

                    b.HasOne("CasinoGodsAPI.Models.Player", "player")
                        .WithMany()
                        .HasForeignKey("playerId");

                    b.Navigation("gameName");

                    b.Navigation("player");
                });

            modelBuilder.Entity("CasinoGodsAPI.TablesModel.BlackjackTablesDatabase", b =>
                {
                    b.HasOne("CasinoGodsAPI.TablesModel.TablesDatabase", "table")
                        .WithMany()
                        .HasForeignKey("tablename");

                    b.Navigation("table");
                });

            modelBuilder.Entity("CasinoGodsAPI.TablesModel.TablesDatabase", b =>
                {
                    b.HasOne("CasinoGodsAPI.Models.GamesDatabase", "game")
                        .WithMany()
                        .HasForeignKey("gameName");

                    b.Navigation("game");
                });
#pragma warning restore 612, 618
        }
    }
}