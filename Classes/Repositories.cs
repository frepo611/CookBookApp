namespace CookBookApp.Classes;

using System;
using CookBookApp.Ingredients;
using CookBookApp.Recipes;
public class RecipesRepository : IRecipesRepository
{
    private readonly string FilePath;
    private readonly IStringsRepository _stringsRepository;
    public RecipesRepository(string filePath, IStringsRepository stringsRepository)
    {
        _stringsRepository = stringsRepository;
        FilePath = filePath;
    }
    public List<Recipe> GetAll()
    {
        var recipesAsStrings = _stringsRepository.Read(FilePath);
        var recipesAsIds = _stringsRepository.GetIdsAsLists(recipesAsStrings);
        var allRecipes = new List<Recipe>();
        foreach (var recipeAsIds in recipesAsIds)
            {   
                var recipe = RecipeFromIds(recipeAsIds);
                allRecipes.Add(recipe);
            }
        return allRecipes;
    }

    private Recipe RecipeFromIds(List<int> recipeAsIds)
    {
        var recipe = new List<Ingredient>();
        foreach (var id in recipeAsIds)
        {
            recipe.Add(IngredientsRegistry.GetIngredient(id));
        }
        return new Recipe(recipe);
    }

    public void Write(List<Recipe> allRecipes)
    {
        var allRecipesAsStrings = new List<string>();
        foreach (var recipe in allRecipes)
        {
            allRecipesAsStrings.Add(recipe.RecipeToText());
        }
        _stringsRepository.Write(FilePath, allRecipesAsStrings);
    }
}


public interface IRecipesRepository
{
    List<Recipe> GetAll();
    void Write(List<Recipe> allRecipes);
}