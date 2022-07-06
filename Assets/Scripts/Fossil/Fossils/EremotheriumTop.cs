public class EremotheriumTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);
        // Player.AquaticAffinity += 5;
    }
    
    public override void OnUnequip()
    {
        // Player.AquaticAffinity -= 5;
    }

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}