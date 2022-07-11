public class DesmodusMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Lightweight += 5;
    }
    
    public override void OnUnequip()
    {
        Player.Lightweight -= 5;
    }

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}