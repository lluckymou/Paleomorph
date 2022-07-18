public class AbelisaurusBottom : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetBottom(BodyPart);
        Player.Defense += 2;
        Player.AquaticAffinity += 2;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 2;
        Player.AquaticAffinity -= 2;
    }
}