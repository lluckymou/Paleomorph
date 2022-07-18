public class GlyptodonBottom : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetBottom(BodyPart);
        Player.Defense += 3;
        Player.AquaticAffinity += 3;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 3;
        Player.AquaticAffinity -= 3;
    }
}