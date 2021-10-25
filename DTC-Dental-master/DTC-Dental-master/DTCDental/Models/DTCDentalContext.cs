using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DTCDental.Models
{
    public class DTCDentalContext : DbContext
    {
        public DTCDentalContext(DbContextOptions<DTCDentalContext> options)
            : base(options)
        { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CompletedService> CompletedServices { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Patient
            #region Relationships
            //Relationship Here
            #endregion

            #region Data
            modelBuilder.Entity<Patient>().HasData(

                new Patient
                {
                    PatientID = 1,
                    FirstName = "Asa",
                    LastName = "Reinke",
                    StreetAddress = "558 County Road 2254",
                    City = "Valley View",
                    State = "Texas",
                    Zip = 76272,
                    PhoneNumber = 9407367750,
                    Email = "asa.reinke@gmail.com",
                    SocialSecurityNumber = 123456789,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 2,
                    FirstName = "Nediljka",
                    LastName = "Bryan",
                    StreetAddress = "47 Todds Lane",
                    City = "San Antonio",
                    State = "Texas",
                    Zip = 78258,
                    PhoneNumber = 2102001482,
                    Email = "jimxugle@comcast.net",
                    SocialSecurityNumber = 123456780,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 3,
                    FirstName = "Gjorgji",
                    LastName = "Seidel",
                    StreetAddress = "3305 Anthony Avenue",
                    City = "Abilene",
                    State = "Texas",
                    Zip = 79602,
                    PhoneNumber = 2102012500,
                    Email = "jnolan@verizon.net",
                    SocialSecurityNumber = 123456781,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 4,
                    FirstName = "Stathis",
                    LastName = "Lobo",
                    StreetAddress = "2869 Bird Springs Lane",
                    City = "Houston",
                    State = "Texas",
                    Zip = 77062,
                    PhoneNumber = 2102025588,
                    Email = "tedrlord@gmail.com",
                    SocialSecurityNumber = 123456782,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 5,
                    FirstName = "Ali",
                    LastName = "Fransson",
                    StreetAddress = "235 Romines Mill Road",
                    City = "Dallas",
                    State = "Texas",
                    Zip = 75204,
                    PhoneNumber = 2102034229,
                    Email = "gozer@yahoo.com",
                    SocialSecurityNumber = 123456783,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 6,
                    FirstName = "Dilwyn",
                    LastName = "Hopson",
                    StreetAddress = "2790 Circle Drive",
                    City = "Houston",
                    State = "Texas",
                    Zip = 77032,
                    PhoneNumber = 2102041698,
                    Email = "hllam@yahoo.com",
                    SocialSecurityNumber = 123456784,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 7,
                    FirstName = "Gopal",
                    LastName = "Peck",
                    StreetAddress = "726 Hall Place",
                    City = "Gary",
                    State = "Texas",
                    Zip = 75643,
                    PhoneNumber = 2102051358,
                    Email = "zilla@icloud.com",
                    SocialSecurityNumber = 123456785,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 8,
                    FirstName = "Fabiola",
                    LastName = "De la Fuente",
                    StreetAddress = "3290 Whitetail Lane",
                    City = "Dallas",
                    State = "Texas",
                    Zip = 75202,
                    PhoneNumber = 2102060140,
                    Email = "ebassi@verizon.net",
                    SocialSecurityNumber = 123456786,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 9,
                    FirstName = "Jan",
                    LastName = "Gal",
                    StreetAddress = "4266 Sussex Court",
                    City = "Valley Mills",
                    State = "Texas",
                    Zip = 76689,
                    PhoneNumber = 2102072013,
                    Email = "djpig@msn.com",
                    SocialSecurityNumber = 123456787,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 10,
                    FirstName = "Waldemar",
                    LastName = "Scholz",
                    StreetAddress = "4391 Anthony Avenue",
                    City = "Abilene",
                    State = "Texas",
                    Zip = 79605,
                    PhoneNumber = 2102085067,
                    Email = "bogjobber@yahoo.ca",
                    SocialSecurityNumber = 123456788,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 11,
                    FirstName = "Rezso",
                    LastName = "Seki",
                    StreetAddress = "1185 Dogwood Road",
                    City = "Austin",
                    State = "Texas",
                    Zip = 73301,
                    PhoneNumber = 2102096771,
                    Email = "kenja@att.net",
                    SocialSecurityNumber = 123456799,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 12,
                    FirstName = "Linda",
                    LastName = "Balodis",
                    StreetAddress = "4736 Ersel Street",
                    City = "Dallas",
                    State = "Texas",
                    Zip = 75215,
                    PhoneNumber = 2102123608,
                    Email = "wildixon@comcast.net",
                    SocialSecurityNumber = 123456779,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 13,
                    FirstName = "Merryn",
                    LastName = "Winther",
                    StreetAddress = "3113 Jones Street",
                    City = "Fort Worth",
                    State = "Texas",
                    Zip = 76102,
                    PhoneNumber = 2102138289,
                    Email = "boftx@live.com",
                    SocialSecurityNumber = 123456769,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 14,
                    FirstName = "Pauline",
                    LastName = "Seaver",
                    StreetAddress = "2257 Hart Ridge Road",
                    City = "Austin",
                    State = "Texas",
                    Zip = 73301,
                    PhoneNumber = 2102148780,
                    Email = "hling@verizon.net",
                    SocialSecurityNumber = 123456759,
                    PatientMinor = false,
                    HeadOfHouse = null
                },
                new Patient
                {
                    PatientID = 15,
                    FirstName = "DeShaun",
                    LastName = "MacQueen",
                    StreetAddress = "1516 White Avenue",
                    City = "Aransas Pass",
                    State = "Texas",
                    Zip = 78336,
                    PhoneNumber = 2102150381,
                    Email = "khris@live.com",
                    SocialSecurityNumber = 123456749,
                    PatientMinor = false,
                    HeadOfHouse = null
                }

                );
            #endregion
            #endregion

            #region Dentist
            modelBuilder.Entity<Dentist>().HasData(
                new Dentist
                {
                    DentistID = 1,
                    FirstName = "Kimberly",
                    LastName = "Baker",
                    HireDate = DateTime.Parse("02/16/2001")

                },
                new Dentist
                {
                    DentistID = 2,
                    FirstName = "Amber",
                    LastName = "Brown",
                    HireDate = DateTime.Parse("05/15/2005")

                },
                new Dentist
                {
                    DentistID = 3,
                    FirstName = "Albert",
                    LastName = "Green",
                    HireDate = DateTime.Parse("03/05/2010")

                },
                new Dentist
                {
                    DentistID = 4,
                    FirstName = "Aaron",
                    LastName = "Dean",
                    HireDate = DateTime.Parse("02/25/2007")

                },
                new Dentist
                {
                    DentistID = 5,
                    FirstName = "Kanye",
                    LastName = "West",
                    HireDate = DateTime.Parse("02/12/2009")

                }
                );
            #endregion

            #region Appointment
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentID = 1,
                    AppointmentDate = DateTime.Today,
                    DentistID = 1,
                    PatientID = 1,
                    TypeID = 1,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 2,
                    DentistID = 1,
                    PatientID = 2,
                    TypeID = 2,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 3,
                    DentistID = 1,
                    PatientID = 3,
                    TypeID = 3,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 4,
                    DentistID = 2,
                    PatientID = 4,
                    TypeID = 4,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 5,
                    DentistID = 2,
                    PatientID = 5,
                    TypeID = 5,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 6,
                    DentistID = 3,
                    PatientID = 6,
                    TypeID = 6,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 7,
                    DentistID = 3,
                    PatientID = 7,
                    TypeID = 7,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 8,
                    DentistID = 4,
                    PatientID = 8,
                    TypeID = 8,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 9,
                    DentistID = 4,
                    PatientID = 9,
                    TypeID = 9,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                },
                new Appointment
                {
                    AppointmentID = 10,
                    DentistID = 5,
                    PatientID = 10,
                    TypeID = 10,
                    AppointmentDate = DateTime.Today,
                    AppointmentStartTime = DateTime.Now,
                    AppointmentEndTime = DateTime.Now // Placeholder
                }
                ); // will need to add: .HasOne(x => x.something).WithMany(y => y.something)
            #endregion

            #region Type
            modelBuilder.Entity<Type>().HasData(
                    new Type
                    {
                        TypeID = 1,
                        Name = "Cosmetic Consultation - Adult",
                        Description = "Initial consultation with adult patient to discuss cosmetic dentistry options.",
                        Duration = 30
                    },
                    new Type
                    {
                        TypeID = 2,
                        Name = "Cosmetic Consultation - Child",
                        Description = "Cosmetic Consultation - Child",
                        Duration = 30
                    },
                    new Type
                    {
                        TypeID = 3,
                        Name = "Cosmetic Consultation - Teen",
                        Description = "Initial consultation with teen patient to discuss cosmetic dentistry options. ",
                        Duration = 30
                    },
                    new Type
                    {
                        TypeID = 4,
                        Name = "Cosmetic Procedure - Adult",
                        Description = "Cosmetic dentistry procedure for adult patient.",
                        Duration = 120
                    },
                    new Type
                    {
                        TypeID = 5,
                        Name = "Cosmetic Procedure - Child",
                        Description = "Cosmetic dentistry procedure for child patient.",
                        Duration = 120
                    },
                    new Type
                    {
                        TypeID = 6,
                        Name = "Cosmetic Procedure - Teen",
                        Description = "Cosmetic dentistry procedure for teen patient.",
                        Duration = 120
                    },
                    new Type
                    {
                        TypeID = 7,
                        Name = "Endodontic Procedure - Adult",
                        Description = "Painless root canal therapy for adults.",
                        Duration = 90
                    },
                    new Type
                    {
                        TypeID = 8,
                        Name = "Endodontic Procedure - Child",
                        Description = "Painless root canal therapy for children.",
                        Duration = 90
                    },
                    new Type
                    {
                        TypeID = 9,
                        Name = "Endodontic Procedure - Teen",
                        Description = "Painless root canal therapy for teens.",
                        Duration = 90
                    },
                    new Type
                    {
                        TypeID = 10,
                        Name = "New Patient - Adult",
                        Description = "Meet new patient, general dental check-up including x-rays and teeth cleaning.",
                        Duration = 30
                    },
                    new Type
                    {
                        TypeID = 11,
                        Name = "New Patient - Child",
                        Description = "Meet new patient, general dental check-up including x-rays and teeth cleaning.",
                        Duration = 30
                    },
                    new Type
                    {
                        TypeID = 12,
                        Name = "New Patient - Teen",
                        Description = "Meet new patient, general dental check-up including x-rays and teeth cleaning.",
                        Duration = 30
                    },
                    new Type
                    {
                        TypeID = 13,
                        Name = "Periodontal Treatment - Adult",
                        Description = "Treatment (both preventative or restorative) for gum diseases.",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 14,
                        Name = "Periodontal Treatment - Child",
                        Description = "Treatment (both preventative or restorative) for gum diseases.",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 15,
                        Name = "Periodontal Treatment - Teen",
                        Description = "Treatment (both preventative or restorative) for gum diseases.",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 16,
                        Name = "Preventative Care - Adult",
                        Description = "General preventative care for an adult patient. The appointment will include x-rays, teeth cleaning, and general oral hygiene advising.",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 17,
                        Name = "Preventative Care - Child",
                        Description = "General preventative care for a child patient. The appointment will include x-rays, teeth cleaning, and general oral hygiene advising. ",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 18,
                        Name = "Preventative Care - Teen",
                        Description = "General preventative care for a teen patient. The appointment will include x-rays, teeth cleaning, and general oral hygiene advising. ",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 19,
                        Name = "Prosthodontic Care - Adult",
                        Description = "Restoration and/or replacement of missing or damaged teeth for adults.",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 20,
                        Name = "Prosthodontic Care - Child",
                        Description = "Restoration and/or replacement of missing or damaged teeth for children.",
                        Duration = 60
                    },
                    new Type
                    {
                        TypeID = 21,
                        Name = "Prosthodontic Care - Teen",
                        Description = "Restoration and/or replacement of missing or damaged teeth for teens.",
                        Duration = 60
                    }
                );
            #endregion

            #region Service
            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    //Insert Data Here
                });
            #endregion

            #region Appointment
                #region Relationships
            modelBuilder.Entity<Appointment>().HasOne(p => p.Patient).WithMany(a => a.Appointments).HasForeignKey(pa => pa.PatientID);
            modelBuilder.Entity<Appointment>().HasOne(d => d.Dentist).WithMany(a => a.Appointments).HasForeignKey(dentist => dentist.DentistID);
            modelBuilder.Entity<Appointment>().HasOne(t => t.Type).WithMany(a => a.Appointments).HasForeignKey(type => type.TypeID);
                #endregion

                #region Data
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    //Insert Data Here
                }
                );
            #endregion
            #endregion

            #region Visit
                #region Relationships
            modelBuilder.Entity<Visit>().HasOne(p => p.Patient).WithMany(v => v.Visits).HasForeignKey(pa => pa.PatientID);
            modelBuilder.Entity<Visit>().HasOne(d => d.Dentist).WithMany(v => v.Visits).HasForeignKey(dentist => dentist.DentistID);
                #endregion

                #region Data
            modelBuilder.Entity<Visit>().HasData(
                new Visit
                {
                    //insert data here
                }
                );
            #endregion
            #endregion

            #region Completed Services
                #region Relationships
            modelBuilder.Entity<CompletedService>().HasKey(key => new {key.ServiceID, key.VisitID });
            modelBuilder.Entity<CompletedService>().HasOne(s => s.Service).WithMany(c => c.CompletedServices).HasForeignKey(s => s.ServiceID);
            modelBuilder.Entity<CompletedService>().HasOne(v => v.Visit).WithMany(c => c.CompletedServices).HasForeignKey(v => v.VisitID);
            #endregion

                #region Data
            modelBuilder.Entity<CompletedService>().HasData(
                new CompletedService
                {
                    //Insert Data Here...
                }
                );
                #endregion
            #endregion
        }
    }
}
