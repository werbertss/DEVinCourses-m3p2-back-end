﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NDDTraining.Infra.Data.Context;

#nullable disable

namespace NDDTraining.Infra.Migrations
{
    [DbContext(typeof(NDDTrainingDbContext))]
    [Migration("20221118235547_ImgUpdate")]
    partial class ImgUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NDDTraining.Domain.Models.CompletedModule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.HasIndex("RegistrationId");

                    b.ToTable("CompletedModule");
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescriptionModule")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("DESCRIPTION_MODULE");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("IMAGE");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("LINK");

                    b.Property<string>("StatusModule")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("STATUS_MODULE");

                    b.Property<string>("TitleModule")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("TITLE_MODULE");

                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.ToTable("MODULES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "vbs7jKRMuiA",
                            StatusModule = "finalizado",
                            TitleModule = "Módulo 1",
                            TrainingId = 1
                        },
                        new
                        {
                            Id = 2,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "3CC_YtyD7Po",
                            StatusModule = "disponivel",
                            TitleModule = "Módulo 2",
                            TrainingId = 1
                        },
                        new
                        {
                            Id = 3,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "TxxkFWty09g",
                            StatusModule = "disponivel",
                            TitleModule = "Módulo 3",
                            TrainingId = 1
                        },
                        new
                        {
                            Id = 4,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "vbs7jKRMuiA",
                            StatusModule = "finalizado",
                            TitleModule = "Módulo 1",
                            TrainingId = 2
                        },
                        new
                        {
                            Id = 5,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "3CC_YtyD7Po",
                            StatusModule = "disponivel",
                            TitleModule = "Módulo 2",
                            TrainingId = 2
                        },
                        new
                        {
                            Id = 6,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "TxxkFWty09g",
                            StatusModule = "disponivel",
                            TitleModule = "Módulo 3",
                            TrainingId = 2
                        },
                        new
                        {
                            Id = 7,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "vbs7jKRMuiA",
                            StatusModule = "finalizado",
                            TitleModule = "Módulo 1",
                            TrainingId = 3
                        },
                        new
                        {
                            Id = 8,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "3CC_YtyD7Po",
                            StatusModule = "disponivel",
                            TitleModule = "Módulo 2",
                            TrainingId = 3
                        },
                        new
                        {
                            Id = 9,
                            DescriptionModule = "Lorem ipsum dolor sit amet consectetur.",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSjOUpolyASUyrLMSV2vqIvQQZ8_--ddMSsJF_xvxZ3tEwPPtZrc57tShVksL8y8JZ8QIk&usqp=CAU",
                            Link = "TxxkFWty09g",
                            StatusModule = "disponivel",
                            TitleModule = "Módulo 3",
                            TrainingId = 3
                        });
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.Registration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("STATUS");

                    b.Property<int>("TrainingId")
                        .HasColumnType("INT")
                        .HasColumnName("TRAINING_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("INT")
                        .HasColumnName("USER_ID");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.HasIndex("UserId");

                    b.ToTable("REGISTRATION", (string)null);
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("ACTIVE");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("CATEGORY");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("DESCRIPTION");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("TIME")
                        .HasColumnName("DURATION");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Teacher")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("TEACHER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("TITLE");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("URL");

                    b.HasKey("Id");

                    b.ToTable("TRAININGS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Category = "tecnologia",
                            Description = "Architecto eaque consectetur nostrum impedit earum at harum. Reiciendis suscipit soluta, ab, repellat ad, Architecto eaque consectetur nostrum impedit earum at harum. Architecto eaque consectetur nostrum impedit earum at harum., Architecto eaque consectetur nostrum impedit earum at harum.",
                            Duration = new TimeSpan(0, 20, 0, 0, 0),
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Teacher = "Carlos Silva",
                            Title = "Manutenção de Computadores",
                            Url = "https://certificadocursosonline.com/wp-content/uploads/2018/07/Curso-de-Manutenc%CC%A7a%CC%83o-de-Computadores.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Category = "idioma",
                            Description = "Neste curso, os alunos irão obter um conhecimento aprofundado sobre os recursos disponíveis sobre Inlges o basico.",
                            Duration = new TimeSpan(2, 22, 0, 0, 0),
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Teacher = "Rodrigo Rosa",
                            Title = "Ingles Basico",
                            Url = "https://setcesp.org.br/wp-content/uploads/2019/08/treinamento.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            Category = "educacao",
                            Description = "Neste curso, os alunos irão obter um conhecimento aprofundado sobre os recursos disponíveis.",
                            Duration = new TimeSpan(0, 18, 0, 0, 0),
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Teacher = "Maria Eduarda",
                            Title = "Redacao",
                            Url = "https://setcesp.org.br/wp-content/uploads/2019/08/treinamento.jpg"
                        });
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("INT")
                        .HasColumnName("AGE");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("VARCHAR")
                        .HasColumnName("IMAGE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("NAME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("PASSWORD");

                    b.HasKey("Id");

                    b.ToTable("USER", (string)null);
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.CompletedModule", b =>
                {
                    b.HasOne("NDDTraining.Domain.Models.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDDTraining.Domain.Models.Registration", "Registration")
                        .WithMany("CompletedModules")
                        .HasForeignKey("RegistrationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.Module", b =>
                {
                    b.HasOne("NDDTraining.Domain.Models.Training", "Training")
                        .WithMany("Modules")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.Registration", b =>
                {
                    b.HasOne("NDDTraining.Domain.Models.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NDDTraining.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.Registration", b =>
                {
                    b.Navigation("CompletedModules");
                });

            modelBuilder.Entity("NDDTraining.Domain.Models.Training", b =>
                {
                    b.Navigation("Modules");
                });
#pragma warning restore 612, 618
        }
    }
}
