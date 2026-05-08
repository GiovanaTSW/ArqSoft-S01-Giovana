using Catalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Controllers
{
    public class CatalogoController : Controller
    {
        private static List<Item> _items = new()
        {
            new Item {
                Id = 1,
                Titulo = "Devil May Cry",
                Genero = "Hack and Slash",
                Ano = 2001,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador..."
            },

            new Item
            {
                Id = 2,
                Titulo = "Castlevania: Symphony of the Night",
                Genero = "Metroidvania",
                Ano = 1997,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego que trata de un cazador..."
            },

            new Item 
            {
                Id = 3,
                Titulo = "Animal Crossing New Horizons",
                Genero = "Simulación Social",
                Ano = 2020,
                Consola = "Nintendo Switch",
                Descripcion = "Escápate a una isla desierta donde puedes decorar, pescar y convivir con vecinos animales en tiempo real."
            },

            new Item
            {
                Id = 4,
                Titulo = "Poppy Playtime Triple Pack",
                Genero = "Horror / Puzles",
                Ano = 2025,
                Consola = "PS5, Xbox, Switch",
                Descripcion = "Recopilación de los tres capítulos donde debes sobrevivir a juguetes asesinos en una fábrica abandonada."
            },

            new Item
            {
                Id = 5,
                Titulo = "Minecraft",
                Genero = "Sandbox",
                Ano = 2011,
                Consola = "Multiplataforma",
                Descripcion = "Un mundo de bloques infinitos para construir, explorar y sobrevivir solo o con amigos."
            },

            new Item
            {
                Id = 6,
                Titulo = "Super Mario Maker 2",
                Genero = "Plataformas",
                Ano = 2019,
                Consola = "Nintendo Switch",
                Descripcion = "Herramienta creativa para diseñar tus propios niveles de Mario y jugar los creados por la comunidad.",
            },

            new Item
            {
                Id = 7,
                Titulo = "Luigi'S Mansion 3",
                Genero = "Acción",
                Ano = 2019,
                Consola = "Nintendo Switch",
                Descripcion = "Luigi explora un hotel encantado para rescatar a sus amigos usando su aspiradora especial para fantasmas."
            }
        };

        //Lista - con filtro opcional por género
        public IActionResult Index(string? genero)
        {
            var resultado = string.IsNullOrEmpty(genero)
                ? _items
                : _items.Where(i => i.Genero == genero).ToList();
            ViewBag.Generos = _items.Select(i => i.Genero).Distinct().ToList();
            ViewBag.GeneroActual = genero;

            return View(resultado);
        }

        //Detalle
        public IActionResult Detalle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            return item == null ? NotFound() : View(item);
        }

        //Formulario - GET
        public IActionResult Agregar()
        {
            return View();
        }

        //Formulario - POST
        [HttpPost]
        public IActionResult Agregar(Item item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
            return RedirectToAction("Index");
        }
    }
}
