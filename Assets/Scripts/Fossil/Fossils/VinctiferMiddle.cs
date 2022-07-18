public class VinctiferMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.AquaticAffinity += 2;
        Player.Lightweight += 2;
    }
    
    public override void OnUnequip()
    {
        Player.AquaticAffinity -= 2;
        Player.Lightweight -= 2;
    }
}