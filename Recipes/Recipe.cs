namespace CookBookApp.Recipes;
using CookBookApp.Ingredients;
public class Recipe
{
    public IEnumerable<Ingredient> Ingredients { get; }
    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }
    public override string ToString()
    {
        var result = new List<string>();
        foreach (var ingredient in Ingredients)
        {
            result.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
        }
        return string.Join(Environment.NewLine, result.ToArray());
    }
}