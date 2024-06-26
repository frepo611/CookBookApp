using CookBookApp.Classes;

string filePath = "recipes.txt";
var stringsRepository = new StringsTextRepository();
var recipesRepository = new RecipesRepository(filePath, stringsRepository);
var recipesUI = new RecipesConsoleUI();
var cookBookApp = new CookBook(recipesRepository, recipesUI);
cookBookApp.Run();