using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using App.Context;

namespace App.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20170602140154_UpdateTopicEntity")]
    partial class UpdateTopicEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Entity.Conference", b =>
                {
                    b.Property<int>("ConferenceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ActivePhasePhaseId");

                    b.Property<float>("ConferenceFee");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ConferenceId");

                    b.HasIndex("ActivePhasePhaseId");

                    b.ToTable("Conferences");
                });

            modelBuilder.Entity("App.Entity.ConferenceUser", b =>
                {
                    b.Property<int>("ConferenceId");

                    b.Property<int>("UserId");

                    b.HasKey("ConferenceId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ConferenceUser");
                });

            modelBuilder.Entity("App.Entity.Phase", b =>
                {
                    b.Property<int>("PhaseId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Name");

                    b.HasKey("PhaseId");

                    b.ToTable("Phases");
                });

            modelBuilder.Entity("App.Entity.Proposal", b =>
                {
                    b.Property<int>("ProposalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbstractPaper");

                    b.Property<string>("FullPaper");

                    b.HasKey("ProposalId");

                    b.ToTable("Proposals");
                });

            modelBuilder.Entity("App.Entity.ProposalMetaInformation", b =>
                {
                    b.Property<int>("ProposalMetaInformationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ProposalForeignKey");

                    b.Property<string>("Title");

                    b.Property<int>("Year");

                    b.HasKey("ProposalMetaInformationId");

                    b.HasIndex("ProposalForeignKey")
                        .IsUnique();

                    b.ToTable("ProposalMetaInformations");
                });

            modelBuilder.Entity("App.Entity.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Slug");

                    b.Property<string>("Title");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("App.Entity.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ConferenceId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("TopicId");

                    b.HasIndex("ConferenceId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("App.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<int?>("ProposalMetaInformationId");

                    b.HasKey("UserId");

                    b.HasIndex("ProposalMetaInformationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("App.Entity.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("App.Entity.Conference", b =>
                {
                    b.HasOne("App.Entity.Phase", "ActivePhase")
                        .WithMany()
                        .HasForeignKey("ActivePhasePhaseId");
                });

            modelBuilder.Entity("App.Entity.ConferenceUser", b =>
                {
                    b.HasOne("App.Entity.Conference", "Conference")
                        .WithMany("Users")
                        .HasForeignKey("ConferenceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Entity.User", "User")
                        .WithMany("ConferenceUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Entity.ProposalMetaInformation", b =>
                {
                    b.HasOne("App.Entity.Proposal", "Proposal")
                        .WithOne("MetaInformation")
                        .HasForeignKey("App.Entity.ProposalMetaInformation", "ProposalForeignKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Entity.Topic", b =>
                {
                    b.HasOne("App.Entity.Conference")
                        .WithMany("Topics")
                        .HasForeignKey("ConferenceId");
                });

            modelBuilder.Entity("App.Entity.User", b =>
                {
                    b.HasOne("App.Entity.ProposalMetaInformation")
                        .WithMany("Authors")
                        .HasForeignKey("ProposalMetaInformationId");
                });

            modelBuilder.Entity("App.Entity.UserRole", b =>
                {
                    b.HasOne("App.Entity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Entity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
