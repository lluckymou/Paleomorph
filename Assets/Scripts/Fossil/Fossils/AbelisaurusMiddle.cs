public class AbelisaurusMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Defense += 3;
        Player.Lightweight += 2;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 3;
        Player.Lightweight -= 2;
    }
}