using Microsoft.EntityFrameworkCore;
using ProjektBlazor.API.Entities;

namespace ProjektBlazor.API.Data
{
    public class KinoDbContext:DbContext
    {
        public KinoDbContext(DbContextOptions<KinoDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Filmy
            #region
            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 1,
                Nazwa = "Szybcy i wściekli: Tokio Drift / Napisy",
                Dlugosc = "104 min",
                Wiek = 16,
                Produkcja = "USA | 2006",
                ImageURL = "/Img/TokioDrift2.jpg",
                ZwiastunURL = "https://www.youtube.com/watch?v=p8HQ2JLlc4E&ab_channel=TheFastSaga"
            });

            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 2,
                Nazwa = "Harry Potter i Insygnia Śmierci: Część II / Napisy",
                Dlugosc = "130 min",
                Wiek = 16,
                Produkcja = "USA | 2011",
                ImageURL = "/Img/HarryPotter2.jpg",
                ZwiastunURL = "https://www.youtube.com/watch?v=mObK5XD8udk&ab_channel=WarnerBros.Pictures"
            });

            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 3,
                Nazwa = "Pulp Fiction / Napisy",
                Dlugosc = "154 min",
                Wiek = 18,
                Produkcja = "USA | 1994",
                ImageURL = "/Img/PulpFiction2.jpg",
                ZwiastunURL = "https://www.youtube.com/watch?v=s7EdQ4FqbhY&ab_channel=Movieclips"
            });

            modelBuilder.Entity<Film>().HasData(new Film
            {
                Id = 4,
                Nazwa = "It / Napisy",
                Dlugosc = "135 min",
                Wiek = 16,
                Produkcja = "USA | 2017",
                ImageURL = "/Img/It2.jpg",
                ZwiastunURL = "https://www.youtube.com/watch?v=FnCdOQsX5kc&ab_channel=WarnerBros.Pictures"
            });
            #endregion //

            //Miejsca
            #region
            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 1,
                Numer = 1,
                Rzad = 1,
                Imie = "Marek",
                Nazwisko = "Gryzoń",
                Email = "mmgz@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 2,
                Numer = 2,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 3,
                Numer = 3,
                Rzad = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "jk@gmail.com",
                Phone = "+49512212123",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 4,
                Numer = 4,
                Rzad = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "jk@gmail.com",
                Phone = "+49512212123",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 5,
                Numer = 5,
                Rzad = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "jk@gmail.com",
                Phone = "+49512212123",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 6,
                Numer = 6,
                Rzad = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "jk@gmail.com",
                Phone = "+49512212123",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 7,
                Numer = 7,
                Rzad = 1,
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "jk@gmail.com",
                Phone = "+49512212123",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 8,
                Numer = 8,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 9,
                Numer = 9,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 10,
                Numer = 10,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 11,
                Numer = 11,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 12,
                Numer = 12,
                Rzad = 1,
                Imie = "Grzegorz",
                Nazwisko = "Nowak",
                Email = "gn@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 13,
                Numer = 1,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 14,
                Numer = 2,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 15,
                Numer = 3,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 16,
                Numer = 4,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 17,
                Numer = 5,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 18,
                Numer = 6,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 19,
                Numer = 7,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 20,
                Numer = 8,
                Rzad = 2,
                Imie = "Anna",
                Nazwisko = "Kowalczyk",
                Email = "annak@wp.pl",
                Phone = "+49123456789",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 21,
                Numer = 9,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 22,
                Numer = 10,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 23,
                Numer = 11,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 24,
                Numer = 12,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 25,
                Numer = 1,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 26,
                Numer = 2,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 27,
                Numer = 3,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 28,
                Numer = 4,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 29,
                Numer = 5,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 30,
                Numer = 6,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 31,
                Numer = 7,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 32,
                Numer = 8,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 33,
                Numer = 9,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 34,
                Numer = 10,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 35,
                Numer = 11,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 36,
                Numer = 12,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 37,
                Numer = 1,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 38,
                Numer = 2,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 39,
                Numer = 3,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 40,
                Numer = 4,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 41,
                Numer = 5,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 42,
                Numer = 6,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 43,
                Numer = 7,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 44,
                Numer = 8,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 45,
                Numer = 9,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 46,
                Numer = 10,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 47,
                Numer = 11,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 48,
                Numer = 12,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 49,
                Numer = 1,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 50,
                Numer = 2,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 51,
                Numer = 3,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 52,
                Numer = 4,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 53,
                Numer = 5,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 54,
                Numer = 6,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 55,
                Numer = 7,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 56,
                Numer = 8,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 57,
                Numer = 9,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 58,
                Numer = 10,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 59,
                Numer = 11,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 60,
                Numer = 12,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 61,
                Numer = 1,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 62,
                Numer = 2,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 63,
                Numer = 3,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 64,
                Numer = 4,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 65,
                Numer = 5,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 66,
                Numer = 6,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 67,
                Numer = 7,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 68,
                Numer = 8,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 69,
                Numer = 9,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 70,
                Numer = 10,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 71,
                Numer = 11,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 72,
                Numer = 12,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 73,
                Numer = 1,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 74,
                Numer = 2,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 75,
                Numer = 3,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 76,
                Numer = 4,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 77,
                Numer = 5,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 78,
                Numer = 6,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 79,
                Numer = 7,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 80,
                Numer = 8,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 81,
                Numer = 9,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 82,
                Numer = 10,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 83,
                Numer = 11,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 84,
                Numer = 12,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 85,
                Numer = 1,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 86,
                Numer = 2,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 87,
                Numer = 3,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 88,
                Numer = 4,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 89,
                Numer = 5,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 90,
                Numer = 6,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 91,
                Numer = 7,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 92,
                Numer = 8,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 93,
                Numer = 9,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 94,
                Numer = 10,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 95,
                Numer = 11,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 96,
                Numer = 12,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 97,
                Numer = 1,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 98,
                Numer = 2,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 99,
                Numer = 3,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 100,
                Numer = 4,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 101,
                Numer = 5,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 102,
                Numer = 6,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 103,
                Numer = 7,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 104,
                Numer = 8,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 105,
                Numer = 9,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 106,
                Numer = 10,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 107,
                Numer = 11,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 108,
                Numer = 12,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 109,
                Numer = 1,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 110,
                Numer = 2,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 111,
                Numer = 3,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 112,
                Numer = 4,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 113,
                Numer = 5,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 114,
                Numer = 6,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 115,
                Numer = 7,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 116,
                Numer = 8,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 117,
                Numer = 9,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 118,
                Numer = 10,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 119,
                Numer = 11,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 120,
                Numer = 12,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 121,
                Numer = 1,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 122,
                Numer = 2,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 123,
                Numer = 3,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 124,
                Numer = 4,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 125,
                Numer = 5,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 126,
                Numer = 6,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 127,
                Numer = 7,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 128,
                Numer = 8,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 129,
                Numer = 9,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 130,
                Numer = 10,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 131,
                Numer = 11,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 132,
                Numer = 12,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 133,
                Numer = 1,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 134,
                Numer = 2,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 135,
                Numer = 3,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 136,
                Numer = 4,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 137,
                Numer = 5,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 138,
                Numer = 6,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 139,
                Numer = 7,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 140,
                Numer = 8,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 141,
                Numer = 9,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 142,
                Numer = 10,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 143,
                Numer = 11,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 144,
                Numer = 12,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 145,
                Numer = 1,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 146,
                Numer = 2,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 147,
                Numer = 3,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 148,
                Numer = 4,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 149,
                Numer = 5,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 150,
                Numer = 6,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 151,
                Numer = 7,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 152,
                Numer = 8,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 153,
                Numer = 9,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 154,
                Numer = 10,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 155,
                Numer = 11,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 156,
                Numer = 12,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 157,
                Numer = 1,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 158,
                Numer = 2,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 159,
                Numer = 3,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 160,
                Numer = 4,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 161,
                Numer = 5,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 162,
                Numer = 6,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 163,
                Numer = 7,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 164,
                Numer = 8,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 165,
                Numer = 9,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 166,
                Numer = 10,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 167,
                Numer = 11,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 168,
                Numer = 12,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 1
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 169,
                Numer = 1,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 170,
                Numer = 2,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 171,
                Numer = 3,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 172,
                Numer = 4,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 173,
                Numer = 5,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 174,
                Numer = 6,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 175,
                Numer = 7,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 176,
                Numer = 8,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 177,
                Numer = 9,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 178,
                Numer = 10,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 179,
                Numer = 11,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 180,
                Numer = 12,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 181,
                Numer = 1,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 182,
                Numer = 2,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 183,
                Numer = 3,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 184,
                Numer = 4,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 185,
                Numer = 5,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 186,
                Numer = 6,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 187,
                Numer = 7,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 188,
                Numer = 8,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 189,
                Numer = 9,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 190,
                Numer = 10,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 191,
                Numer = 11,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 192,
                Numer = 12,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 193,
                Numer = 1,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 194,
                Numer = 2,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 195,
                Numer = 3,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 196,
                Numer = 4,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 197,
                Numer = 5,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 198,
                Numer = 6,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 199,
                Numer = 7,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 200,
                Numer = 8,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 201,
                Numer = 9,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 202,
                Numer = 10,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 203,
                Numer = 11,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 204,
                Numer = 12,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 205,
                Numer = 1,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 206,
                Numer = 2,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 207,
                Numer = 3,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 208,
                Numer = 4,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 209,
                Numer = 5,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 210,
                Numer = 6,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 211,
                Numer = 7,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 212,
                Numer = 8,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 213,
                Numer = 9,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 214,
                Numer = 10,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 215,
                Numer = 11,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 216,
                Numer = 12,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 217,
                Numer = 1,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 218,
                Numer = 2,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 219,
                Numer = 3,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 220,
                Numer = 4,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 221,
                Numer = 5,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 222,
                Numer = 6,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 223,
                Numer = 7,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 224,
                Numer = 8,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 225,
                Numer = 9,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 226,
                Numer = 10,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 227,
                Numer = 11,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 228,
                Numer = 12,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 229,
                Numer = 1,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 230,
                Numer = 2,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 231,
                Numer = 3,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 232,
                Numer = 4,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 233,
                Numer = 5,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 234,
                Numer = 6,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 235,
                Numer = 7,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 236,
                Numer = 8,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 237,
                Numer = 9,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 238,
                Numer = 10,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 239,
                Numer = 11,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 240,
                Numer = 12,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 241,
                Numer = 1,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 242,
                Numer = 2,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 243,
                Numer = 3,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 244,
                Numer = 4,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 245,
                Numer = 5,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 246,
                Numer = 6,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 247,
                Numer = 7,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 248,
                Numer = 8,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 249,
                Numer = 9,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 250,
                Numer = 10,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 251,
                Numer = 11,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 252,
                Numer = 12,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 253,
                Numer = 1,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 254,
                Numer = 2,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 255,
                Numer = 3,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 256,
                Numer = 4,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 257,
                Numer = 5,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 258,
                Numer = 6,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 259,
                Numer = 7,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 260,
                Numer = 8,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 261,
                Numer = 9,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 262,
                Numer = 10,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 263,
                Numer = 11,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 264,
                Numer = 12,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 265,
                Numer = 1,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 266,
                Numer = 2,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 267,
                Numer = 3,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 268,
                Numer = 4,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 269,
                Numer = 5,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 270,
                Numer = 6,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 271,
                Numer = 7,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 272,
                Numer = 8,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 273,
                Numer = 9,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 274,
                Numer = 10,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 275,
                Numer = 11,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 276,
                Numer = 12,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 277,
                Numer = 1,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 278,
                Numer = 2,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 279,
                Numer = 3,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 280,
                Numer = 4,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 281,
                Numer = 5,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 282,
                Numer = 6,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 283,
                Numer = 7,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 284,
                Numer = 8,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 285,
                Numer = 9,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 286,
                Numer = 10,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 287,
                Numer = 11,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 288,
                Numer = 12,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 289,
                Numer = 1,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 290,
                Numer = 2,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 291,
                Numer = 3,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 292,
                Numer = 4,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 293,
                Numer = 5,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 294,
                Numer = 6,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 295,
                Numer = 7,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 296,
                Numer = 8,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 297,
                Numer = 9,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 298,
                Numer = 10,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 299,
                Numer = 11,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 300,
                Numer = 12,
                Rzad = 11,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 301,
                Numer = 1,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 302,
                Numer = 2,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 303,
                Numer = 3,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 304,
                Numer = 4,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 305,
                Numer = 5,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 306,
                Numer = 6,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 307,
                Numer = 7,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 308,
                Numer = 8,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 309,
                Numer = 9,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 310,
                Numer = 10,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 311,
                Numer = 11,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 312,
                Numer = 12,
                Rzad = 12,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 313,
                Numer = 1,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 314,
                Numer = 2,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 315,
                Numer = 3,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 316,
                Numer = 4,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 317,
                Numer = 5,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 318,
                Numer = 6,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 319,
                Numer = 7,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 320,
                Numer = 8,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 321,
                Numer = 9,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 322,
                Numer = 10,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 323,
                Numer = 11,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 324,
                Numer = 12,
                Rzad = 13,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 325,
                Numer = 1,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 326,
                Numer = 2,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 327,
                Numer = 3,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 328,
                Numer = 4,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 329,
                Numer = 5,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 330,
                Numer = 6,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 331,
                Numer = 7,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 332,
                Numer = 8,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 333,
                Numer = 9,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 334,
                Numer = 10,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 335,
                Numer = 11,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 336,
                Numer = 12,
                Rzad = 14,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 2
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 337,
                Numer = 1,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 338,
                Numer = 2,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 339,
                Numer = 3,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 340,
                Numer = 4,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 341,
                Numer = 5,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 342,
                Numer = 6,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 343,
                Numer = 7,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 344,
                Numer = 8,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 345,
                Numer = 9,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 346,
                Numer = 10,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 347,
                Numer = 11,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 348,
                Numer = 12,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 349,
                Numer = 1,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 350,
                Numer = 2,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 351,
                Numer = 3,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 352,
                Numer = 4,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 353,
                Numer = 5,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 354,
                Numer = 6,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 355,
                Numer = 7,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 356,
                Numer = 8,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 357,
                Numer = 9,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 358,
                Numer = 10,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 359,
                Numer = 11,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 360,
                Numer = 12,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 361,
                Numer = 1,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 362,
                Numer = 2,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 363,
                Numer = 3,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 364,
                Numer = 4,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 365,
                Numer = 5,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 366,
                Numer = 6,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 367,
                Numer = 7,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 368,
                Numer = 8,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 369,
                Numer = 9,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 370,
                Numer = 10,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 371,
                Numer = 11,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 372,
                Numer = 12,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 373,
                Numer = 1,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 374,
                Numer = 2,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 375,
                Numer = 3,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 376,
                Numer = 4,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 377,
                Numer = 5,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 378,
                Numer = 6,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 379,
                Numer = 7,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 380,
                Numer = 8,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 381,
                Numer = 9,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 382,
                Numer = 10,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 383,
                Numer = 11,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 384,
                Numer = 12,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 385,
                Numer = 1,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 386,
                Numer = 2,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 387,
                Numer = 3,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 388,
                Numer = 4,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 389,
                Numer = 5,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 390,
                Numer = 6,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 391,
                Numer = 7,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 392,
                Numer = 8,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 393,
                Numer = 9,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 394,
                Numer = 10,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 395,
                Numer = 11,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 396,
                Numer = 12,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 397,
                Numer = 1,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 398,
                Numer = 2,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 399,
                Numer = 3,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 400,
                Numer = 4,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 401,
                Numer = 5,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 402,
                Numer = 6,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 403,
                Numer = 7,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 404,
                Numer = 8,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 405,
                Numer = 9,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 406,
                Numer = 10,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 407,
                Numer = 11,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 408,
                Numer = 12,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 409,
                Numer = 1,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 410,
                Numer = 2,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 411,
                Numer = 3,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 412,
                Numer = 4,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 413,
                Numer = 5,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 414,
                Numer = 6,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 415,
                Numer = 7,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 416,
                Numer = 8,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 417,
                Numer = 9,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 418,
                Numer = 10,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 419,
                Numer = 11,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 420,
                Numer = 12,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 421,
                Numer = 1,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 422,
                Numer = 2,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 423,
                Numer = 3,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 424,
                Numer = 4,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 425,
                Numer = 5,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 426,
                Numer = 6,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 427,
                Numer = 7,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 428,
                Numer = 8,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 429,
                Numer = 9,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 430,
                Numer = 10,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 431,
                Numer = 11,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 432,
                Numer = 12,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 433,
                Numer = 1,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 434,
                Numer = 2,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 435,
                Numer = 3,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 436,
                Numer = 4,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 437,
                Numer = 5,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 438,
                Numer = 6,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 439,
                Numer = 7,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 440,
                Numer = 8,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 441,
                Numer = 9,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 442,
                Numer = 10,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 443,
                Numer = 11,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 444,
                Numer = 12,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 445,
                Numer = 1,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 446,
                Numer = 2,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 447,
                Numer = 3,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 448,
                Numer = 4,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 449,
                Numer = 5,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 450,
                Numer = 6,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 451,
                Numer = 7,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 452,
                Numer = 8,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 453,
                Numer = 9,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 454,
                Numer = 10,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 455,
                Numer = 11,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 456,
                Numer = 12,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 3
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 457,
                Numer = 1,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 458,
                Numer = 2,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 459,
                Numer = 3,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 460,
                Numer = 4,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 461,
                Numer = 5,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 462,
                Numer = 6,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 463,
                Numer = 7,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 464,
                Numer = 8,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 465,
                Numer = 9,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 466,
                Numer = 10,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 467,
                Numer = 11,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 468,
                Numer = 12,
                Rzad = 1,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 469,
                Numer = 1,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 470,
                Numer = 2,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 471,
                Numer = 3,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 472,
                Numer = 4,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 473,
                Numer = 5,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 474,
                Numer = 6,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 475,
                Numer = 7,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 476,
                Numer = 8,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 477,
                Numer = 9,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 478,
                Numer = 10,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 479,
                Numer = 11,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 480,
                Numer = 12,
                Rzad = 2,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 481,
                Numer = 1,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 482,
                Numer = 2,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 483,
                Numer = 3,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 484,
                Numer = 4,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 485,
                Numer = 5,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 486,
                Numer = 6,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 487,
                Numer = 7,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 488,
                Numer = 8,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 489,
                Numer = 9,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 490,
                Numer = 10,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 491,
                Numer = 11,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 492,
                Numer = 12,
                Rzad = 3,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 493,
                Numer = 1,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 494,
                Numer = 2,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 495,
                Numer = 3,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 496,
                Numer = 4,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 497,
                Numer = 5,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 498,
                Numer = 6,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 499,
                Numer = 7,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 500,
                Numer = 8,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 501,
                Numer = 9,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 502,
                Numer = 10,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 503,
                Numer = 11,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 504,
                Numer = 12,
                Rzad = 4,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 505,
                Numer = 1,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 506,
                Numer = 2,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 507,
                Numer = 3,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 508,
                Numer = 4,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 509,
                Numer = 5,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 510,
                Numer = 6,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 511,
                Numer = 7,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 512,
                Numer = 8,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 513,
                Numer = 9,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 514,
                Numer = 10,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 515,
                Numer = 11,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 516,
                Numer = 12,
                Rzad = 5,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 517,
                Numer = 1,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 518,
                Numer = 2,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 519,
                Numer = 3,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 520,
                Numer = 4,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 521,
                Numer = 5,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 522,
                Numer = 6,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 523,
                Numer = 7,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 524,
                Numer = 8,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 525,
                Numer = 9,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 526,
                Numer = 10,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 527,
                Numer = 11,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 528,
                Numer = 12,
                Rzad = 6,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 529,
                Numer = 1,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 530,
                Numer = 2,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 531,
                Numer = 3,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 532,
                Numer = 4,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 533,
                Numer = 5,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 534,
                Numer = 6,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 535,
                Numer = 7,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 536,
                Numer = 8,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 537,
                Numer = 9,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 538,
                Numer = 10,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 539,
                Numer = 11,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 540,
                Numer = 12,
                Rzad = 7,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 541,
                Numer = 1,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 542,
                Numer = 2,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 543,
                Numer = 3,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 544,
                Numer = 4,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 545,
                Numer = 5,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 546,
                Numer = 6,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 547,
                Numer = 7,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 548,
                Numer = 8,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 549,
                Numer = 9,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 550,
                Numer = 10,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 551,
                Numer = 11,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 552,
                Numer = 12,
                Rzad = 8,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 553,
                Numer = 1,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 554,
                Numer = 2,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 555,
                Numer = 3,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 556,
                Numer = 4,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 557,
                Numer = 5,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 558,
                Numer = 6,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 559,
                Numer = 7,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 560,
                Numer = 8,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 561,
                Numer = 9,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 562,
                Numer = 10,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 563,
                Numer = 11,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 564,
                Numer = 12,
                Rzad = 9,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 565,
                Numer = 1,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 566,
                Numer = 2,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 567,
                Numer = 3,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 568,
                Numer = 4,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 569,
                Numer = 5,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 570,
                Numer = 6,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 571,
                Numer = 7,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 572,
                Numer = 8,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 573,
                Numer = 9,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 574,
                Numer = 10,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 575,
                Numer = 11,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });

            modelBuilder.Entity<Miejsce>().HasData(new Miejsce
            {
                Id = 576,
                Numer = 12,
                Rzad = 10,
                Imie = "",
                Nazwisko = "",
                Email = "",
                Phone = "",
                FilmId = 4
            });
            #endregion

        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Miejsce> Miejsca { get; set; }


    }
}
