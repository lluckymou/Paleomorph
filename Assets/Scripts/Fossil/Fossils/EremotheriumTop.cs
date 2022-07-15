public class EremotheriumTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);
        Player.Defense += 1;
        Player.Sight += 1;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 1;
        Player.Sight -= 1;
    }
}