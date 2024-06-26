namespace CookBookApp.Ingredients;
public class IngredientsRegistry
{
    public static List<Ingredient> All {get;} = new List<Ingredient> {
                new WheatFlour(),
                new CoconutFlour(),
                new Butter(),
                new Chocolate(),
                new Sugar(),
                new Cardamom(),
                new Cinnamon(),
                new CocoaPowder()
            };
    public static Ingredient GetIngredient(int id)
    {
        foreach (var ingredient in All)
        {
            if (id == ingredient.Id)
            {
                return ingredient;
            }
        }            
        return null;
    }
}
