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
    public string RecipeToText()
    {
        var ingredientIDs = new List<int>();

        foreach (var ingredient in Ingredients)
        {
            ingredientIDs.Add(ingredient.Id);
        }
    return string.Join(',', ingredientIDs);
    }

}