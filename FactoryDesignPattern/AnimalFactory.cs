namespace FactoryDesignPattern;

public class AnimalFactory
{
    public IAnimal CreateAnimal(string animalType)
    {
        if (animalType == "Dog")
            return new Dog();
        else if (animalType == "Cat")
            return new Cat();
        else
            throw new ArgumentException("Bilinmeyen hayvan tipi");
    }
}