public class DesmodusTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);
        Player.Sight += 3;
        Player.Lightweight += 2;
    }
    
    public override void OnUnequip()
    {
        Player.Sight -= 3;
        Player.Lightweight -= 2;
    }
}