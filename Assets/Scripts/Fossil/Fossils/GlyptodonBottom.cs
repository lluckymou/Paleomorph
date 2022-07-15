public class GlyptodonBottom : Fossil
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

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}