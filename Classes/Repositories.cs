namespace CookBookApp.Classes;
using CookBookApp.Ingredients;
using CookBookApp.Recipes;
public class RecipesRepository : IRecipesRepository
{
    private readonly string FilePath;
    public RecipesRepository(string filePath)
    {
        FilePath = filePath;
    }
    public List<Recipe> GetAll()
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Cardamom()
            }),
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Butter(),
                new Chocolate()
            })
        };
    }

    public void Write(List<Recipe> allRecipes)
    {
        Console.WriteLine($"SKRIVET");
    }
}


public interface IRecipesRepository
{
    List<Recipe> GetAll();
    void Write(List<Recipe> allRecipes);
}