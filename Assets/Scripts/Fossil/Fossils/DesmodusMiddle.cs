public class DesmodusMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Lightweight += 2;
    }
    
    public override void OnUnequip()
    {
        Player.Lightweight -= 2;
    }
}