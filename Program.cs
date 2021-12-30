var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/animal", () => {
    
    Animal animal1 = new Animal();
    Animal animal2 = new Chancho();
    Animal animal3 = new Perro();

        
    var animales = new List<string>();

    animales.Add(animal1.animalSound());
    animales.Add(animal2.animalSound());
    animales.Add(animal3.animalSound());

    return animales;

});

app.Run();
