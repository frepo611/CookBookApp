using CookBookApp.Recipes;
using CookBookApp.Classes;
using CookBookApp.Ingredients;

string filePath = "";
var recipesRepository = new RecipesRepository(filePath);
var recipesUI = new RecipesConsoleUI();
var cookBookApp = new CookBook(recipesRepository, recipesUI);
cookBookApp.Run();