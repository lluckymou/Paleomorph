public class DesmodusBottom : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetBottom(BodyPart);
        Player.Sight += 1;
        Player.Lightweight += 1;
    }
    
    public override void OnUnequip()
    {
        Player.Sight -= 1;
        Player.Lightweight -= 1;
    }
}