public class AbelisaurusBottom : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetBottom(BodyPart);
        Player.Defense += 1;
        Player.AquaticAffinity += 1;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 1;
        Player.AquaticAffinity -= 1;
    }

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}