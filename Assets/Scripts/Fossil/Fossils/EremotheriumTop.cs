public class EremotheriumTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);
        Player.Defense += 2;
        Player.Sight += 2;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 2;
        Player.Sight -= 2;
    }
}