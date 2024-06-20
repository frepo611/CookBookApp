using CookBookApp.Recipes;
using CookBookApp.Classes;
public class CookBook
{
    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUI _recipesUI;

    public CookBook(IRecipesRepository recipesRepository, IRecipesUI recipesUI)
    {
        _recipesRepository = recipesRepository;
        _recipesUI = recipesUI;
    }
    public void Run()
    {
        var allRecipes = _recipesRepository.GetAll();
        _recipesUI.ShowRecipe(allRecipes);
        _recipesUI.PromptToCreateRecipe();
        var ingredients = _recipesUI.ReadIngredientsFromUser();

        if (ingredients.Any())
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(allRecipes);
            _recipesUI.ShowMessage("Recipe added:");
            _recipesUI.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUI.ShowMessage("No ingredients have been selected. Recipe will not be saved");
        }
        _recipesUI.Exit();
    }
}