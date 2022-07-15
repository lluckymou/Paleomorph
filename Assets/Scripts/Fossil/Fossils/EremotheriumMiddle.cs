public class EremotheriumMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Defense += 1;
        Player.Lightweight -= 2;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 1;
        Player.Lightweight += 2;
    }
}