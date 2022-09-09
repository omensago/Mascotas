using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;


namespace MascotaFeliz.App.Consola
{
    class Program
    {

        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddVeterinario();

        }

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Mario",
                Apellidos = "Sandoval",
                Direccion = "casa 21",
                Telefono = "60565546546",
                TarjetaProfesional = "11111111"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Tito",
                Color = "Negro con Blanco",
                Especie = "Perro",
                Raza = "Pinche"
            };
            _repoMascota.AddMascota(mascota);
        }
        private static void AddHistoria()
        {
            var historia = new Historia
            {
                fecha = new DateTime(2012, 1, 1)
            };
            _repoHistoria.AddHistoria(historia);
        }

    }
}
