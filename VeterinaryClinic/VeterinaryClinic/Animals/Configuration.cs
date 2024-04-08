namespace VeterinaryClinic.Animals;

public static class Configuration {
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app) {
        //... GET /api/v1/animals
        app.MapGet("/animals", (IAnimalsService service) => {
            //todo
            return TypedResults.Ok(service.GetAnimals());
        });
        //... POST /api/v1/animals
        //... GET /api/v1/animals/{id}
        app.MapGet("/api/v1/animals/{id:int}", (int id) => {
            //todo
            return TypedResults.Ok();
        });
        //... PUT /api/v1/animals/{id}
        app.MapPut("/api/v1/animals/{id:int}", (Animal newAnimal) => {
            //todo
            return TypedResults.Ok();
        });
        //... DELETE /api/v1/animals/{id}
    }
}