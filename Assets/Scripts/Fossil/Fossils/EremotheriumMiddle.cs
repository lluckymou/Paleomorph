public class EremotheriumMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Defense += 2;
        Player.Lightweight -= 3;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 2;
        Player.Lightweight += 3;
    }
}