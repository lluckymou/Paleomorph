public class VinctiferMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.AquaticAffinity += 1;
        Player.Lightweight += 1;
    }
    
    public override void OnUnequip()
    {
        Player.AquaticAffinity -= 1;
        Player.Lightweight -= 1;
    }

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}