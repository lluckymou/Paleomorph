public class VinctiferBottom : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetBottom(BodyPart);
        Player.AquaticAffinity += 3;
        Player.Lightweight += 1;
    }
    
    public override void OnUnequip()
    {
        Player.AquaticAffinity -= 3;
        Player.Lightweight -= 1;
    }
}