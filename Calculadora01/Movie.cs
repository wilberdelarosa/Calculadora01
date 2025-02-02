using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Calculadora01
    {
        public class Movie
        {
            public string Image { get; set; }
            public string Title { get; set; }

            // Arreglo con elementos: bodas y otras películas
            public static Movie[] Items = new Movie[]
            {
            new Movie { Image = "banner1.jpg", Title = "Boda Grande - Boda Pequeña" },
            new Movie { Image = "banner2.png", Title = "Boda Especial - Momentos Únicos" },
            new Movie { Image = "banner3.png", Title = "Boda Inolvidable - Amor Eterno" },
            new Movie { Image = "movie2.png", Title = "Película Increíble - Acción" },
            new Movie { Image = "movie3.png", Title = "Romance - La Historia" }
            };
        }
    }


