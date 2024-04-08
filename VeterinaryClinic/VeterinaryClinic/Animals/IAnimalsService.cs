namespace VeterinaryClinic.Animals; 

public class IAnimalsService {
    public IEnumerable<Animal> GetAnimals() {
        return new List<Animal>();
    }
}