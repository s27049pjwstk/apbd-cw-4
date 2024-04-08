using System.Data.SqlClient;

namespace VeterinaryClinic.Animals; 

public class AnimalRepository : IAnimalRepository {
    private IConfiguration _configuration;

    public AnimalRepository(IConfiguration configuration) {
        _configuration = configuration;
    }


    public IEnumerable<Animal> GetAnimals() {
        using var con = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        con.Open();
        
        using var cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT IdAnimal, Name, Category, Weight, Color, IndexNumber FROM Animal ORDER BY LastName, FirstName";
        
        var dr = cmd.ExecuteReader();
        var animals = new List<Animal>();
        while (dr.Read())
        {
            var grade = new Animal
            {
                IdAnimal = (int)dr["IdAnimal"],
                Name = dr["Name"].ToString(),
                Category = dr["Category"].ToString(),
                Weight = dr["Weight"].ToString(),
                Color = dr["Color"].ToString(),
                IndexNumber = (int)dr["IndexNumber"]
            };
            animals.Add(grade);
        }
        
        return animals;
    }

    public Animal GetAnimal(int idAnimal) {
        throw new NotImplementedException();
    }

    public int CreateAnimal(Animal animal) {
        throw new NotImplementedException();
    }

    public int UpdateAnimal(Animal animal) {
        throw new NotImplementedException();
    }

    public int DeleteAnimal(int idAnimal) {
        throw new NotImplementedException();
    }
}