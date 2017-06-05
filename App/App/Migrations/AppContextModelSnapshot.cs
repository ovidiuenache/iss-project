using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using App.Context;

namespace App.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Description");

                    b.Property<string>("FullPaper");

                    b.Property<int?>("SectionId");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Title");

                    b.Property<int>("Year");

                    b.HasKey("ProposalId");

                    b.HasIndex("SectionId");

                    b.ToTable("Proposals");
                });

            modelBuilder.Entity("App.Entity.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("ProposalId");

                    b.Property<string>("Qualifier");

                    b.Property<int?>("ReviewerUserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProposalId");

                    b.HasIndex("ReviewerUserId");

                    b.ToTable("Reviews");
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

            modelBuilder.Entity("App.Entity.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Room");

                    b.Property<int?>("SectionLeaderUserId");

                    b.HasKey("SectionId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Room")
                        .IsUnique();

                    b.HasIndex("SectionLeaderUserId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("App.Entity.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ConferenceId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("SectionId");

                    b.HasKey("TopicId");

                    b.HasIndex("ConferenceId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("SectionId");

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

                    b.Property<int?>("ProposalId");

                    b.Property<int?>("SectionId");

                    b.HasKey("UserId");

                    b.HasIndex("ProposalId");

                    b.HasIndex("SectionId");

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

            modelBuilder.Entity("App.Entity.UserSection", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("SectionId");

                    b.HasKey("UserId", "SectionId");

                    b.HasIndex("SectionId");

                    b.ToTable("UserSection");
                });

            modelBuilder.Entity("App.Entity.Conference", b =>
                {
                    b.HasOne("App.Entity.Phase", "ActivePhase")
                        .WithMany("Conferences")
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
            modelBuilder.Entity("App.Entity.Proposal", b =>
                {
                    b.HasOne("App.Entity.Section")
                        .WithMany("Proposals")
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("App.Entity.Review", b =>
                {
                    b.HasOne("App.Entity.Proposal", "Proposal")
                        .WithMany()
                        .HasForeignKey("ProposalId");

                    b.HasOne("App.Entity.User", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerUserId");
                });

            modelBuilder.Entity("App.Entity.Section", b =>
                {
                    b.HasOne("App.Entity.User", "SectionLeader")
                        .WithMany()
                        .HasForeignKey("SectionLeaderUserId");
                });

            modelBuilder.Entity("App.Entity.Topic", b =>
                {
                    b.HasOne("App.Entity.Conference")
                        .WithMany("Topics")
                        .HasForeignKey("ConferenceId");

                    b.HasOne("App.Entity.Section")
                        .WithMany("Topics")
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("App.Entity.User", b =>
                {
                    b.HasOne("App.Entity.Proposal")
                        .WithMany("Authors")
                        .HasForeignKey("ProposalId");

                    b.HasOne("App.Entity.Section")
                        .WithMany("Authors")
                        .HasForeignKey("SectionId");
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

            modelBuilder.Entity("App.Entity.UserSection", b =>
                {
                    b.HasOne("App.Entity.Section", "Section")
                        .WithMany("UserSections")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Entity.User", "User")
                        .WithMany("UserSections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
