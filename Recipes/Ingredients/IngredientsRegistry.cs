namespace CookBookApp.Ingredients;
public class IngredientsRegistry
{
    public List<Ingredient> All {get;} = new List<Ingredient> {
                new WheatFlour(),
                new CoconutFlour(),
                new Butter(),
                new Chocolate(),
                new Sugar(),
                new Cardamom(),
                new Cinnamon(),
                new CocoaPowder()
            };
}