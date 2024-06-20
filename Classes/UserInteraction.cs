namespace CookBookApp.Classes;
using CookBookApp.Ingredients;
using CookBookApp.Recipes;
public interface IRecipesUI
{
    void Exit();
    void PromptToCreateRecipe();
    List<Ingredient> ReadIngredientsFromUser();
    void ShowRecipe(IEnumerable<Recipe> allRecipes);
    void ShowMessage(string message);
}
public class RecipesConsoleUI : IRecipesUI
{
    private readonly IngredientsRegistry _allIngredients = new IngredientsRegistry();
    public void Exit()
    {
        ShowMessage("Press any key to quit");
        Console.ReadKey();
    }
    public void PromptToCreateRecipe()
    {
        Console.WriteLine($"Create a new cookie recipe! Available ingredients are:");
        foreach (var ingredient in _allIngredients.All)
        {
            Console.WriteLine($"{ingredient}");
        }
    }
    public List<Ingredient> ReadIngredientsFromUser()
    {
        var result = new List<Ingredient>();
        Console.Write($"Add an ingredient by its ID, or type anything else to finish: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int id))
                {
                    foreach (var ingredient in _allIngredients.All)
                    {
                        if (ingredient.Id == id)
                        {
                            result.Add(ingredient);
                        }
                    }
                }
            else break;
        }
        return result;
    }
    public void ShowRecipe(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Any())
        {
            int number = 1;
            Console.WriteLine($"Here are the recipes:");
            Console.WriteLine();
            foreach (var item in allRecipes)
            {
                Console.WriteLine($"*****{number}*****");
                Console.WriteLine($"{item}");
                Console.WriteLine();
                ++number;
            }
        }
    }
    public void ShowMessage(string message)
    {
        Console.WriteLine($"{message}");
    }
}