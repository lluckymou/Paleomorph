public class AbelisaurusMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
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