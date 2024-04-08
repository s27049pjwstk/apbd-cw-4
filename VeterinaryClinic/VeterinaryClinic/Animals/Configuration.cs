namespace VeterinaryClinic.Animals;

public static class Configuration {
    public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app) {
        //... GET /api/v1/animals
        app.MapGet("/animals", () => {
            //...
            //...
            return TypedResults.Ok();
        });
        //... POST /api/v1/animals
        //... GET /api/v1/animals/{id}
        //... PUT /api/v1/animals/{id}
        //... DELETE /api/v1/animals/{id}
    }
}