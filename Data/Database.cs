using ShoppingCart.Modelos;

namespace ShoppingCart.Data
{
    public class Database
    {
        public static List<Producto> Productos { get; set; } = new List<Producto>
        {
            new Producto
            {
                Nombre = "101 eassys that will change the way you think",
                Unidades = 20,
                Precio = 700m,
                ImagenArt = "./css/img/101 eassys that will change the way you think.jpg"
            },
            new Producto
            {
                Nombre = "A storytelling workbook for beginners",
                Unidades = 20,
                Precio = 500m,
                ImagenArt = "./css/img/A storytelling workbook for beginners.jpg"
            },
            new Producto
            {
                Nombre = "Alex Rider stormbreaker",
                Unidades = 10,
                Precio = 1950m,
                ImagenArt ="./css/img/Alex Rider stormbreaker.jpg"
            },
            new Producto
            {
                Nombre = "Happy",
                Unidades = 20 ,
                Precio = 700m,
                ImagenArt ="./css/img/Happy.jpg"
            },
            new Producto
            {
                Nombre = "How innovation works",
                Unidades = 20,
                Precio = 500m,
                ImagenArt ="./css/img/How innovation works.jpg"
            },
            new Producto
            {
                Nombre = "Milk and honey",
                Unidades = 10,
                Precio = 1950m,
                ImagenArt ="./css/img/Milk and honey.jpg"
            },
            new Producto
            {
                Nombre = "The psichology of money",
                Unidades = 20,
                Precio = 700m,
                ImagenArt ="./css/img/The psichology of money.jpg"
            },
            new Producto
            {
                Nombre = "The subtle art of not giving a fuck",
                Unidades = 20,
                Precio = 500m,
                ImagenArt ="./css/img/The subtle art of not giving a fuck.jpg"
            },
            new Producto
            {
                Nombre = "The two tower",
                Unidades = 10,
                Precio = 1950m,
                ImagenArt ="./css/img/The two tower.jpg",
            },
            new Producto
            {
                Nombre = "Your soul is a river",
                Unidades = 20,
                Precio = 700m,
                ImagenArt = "./css/img/Your soul is a river.jpg"
            },
            
        };

    }


}