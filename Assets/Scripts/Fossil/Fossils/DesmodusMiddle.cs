public class DesmodusMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Lightweight += 3;
    }
    
    public override void OnUnequip()
    {
        Player.Lightweight -= 3;
    }
}