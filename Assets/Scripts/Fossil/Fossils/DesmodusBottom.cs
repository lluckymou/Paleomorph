public class DesmodusBottom : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetBottom(BodyPart);
        Player.Sight += 2;
        Player.Lightweight += 2;
    }
    
    public override void OnUnequip()
    {
        Player.Sight -= 2;
        Player.Lightweight -= 2;
    }
}