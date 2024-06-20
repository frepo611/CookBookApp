namespace CookBookApp.Ingredients;
public abstract class Ingredient
{
     public abstract int Id { get; }
     public abstract string Name { get; }
     public virtual string PreparationInstructions => "Shake vigorously";
     public override string ToString() => $"{Id}. {Name}";
}
public abstract class Flour : Ingredient
{
    public override string PreparationInstructions => $"Sieve. {base.PreparationInstructions}";
}
public class WheatFlour : Flour
{
    public override int Id => 1;
    public override string Name => "Wheat flour";
}
public class CoconutFlour : Flour
{
    public override int Id => 2;
    public override string Name => "Coconut flour";
}
public class Butter : Ingredient
{
    public override int Id => 3;
    public override string Name => "Butter";
    public override string PreparationInstructions => $"Melt on low heat. {base.PreparationInstructions}";
}
public class Chocolate : Ingredient
{
    public override int Id => 4;
    public override string Name => "Chocolate";
    public override string PreparationInstructions => $"Melt in a water bath. {base.PreparationInstructions}";
}
public class Sugar : Ingredient
{
    public override int Id => 5;
    public override string Name => "Sugar";
    public override string PreparationInstructions => $"{base.PreparationInstructions}";
}

public abstract class Spice : Ingredient
{
    public override string PreparationInstructions => $"Take half a teaspoon. {base.PreparationInstructions}";
}
public class Cardamom : Spice
{
    public override int Id => 6;
    public override string Name => "Cardamom";
}
public class Cinnamon : Spice
{
    public override int Id => 7;
    public override string Name => "Cinnamon";
}
public class CocoaPowder : Ingredient
{
    public override int Id => 8;
    public override string Name => "CocoaPowder";
    public override string PreparationInstructions => $"{base.PreparationInstructions}";
}