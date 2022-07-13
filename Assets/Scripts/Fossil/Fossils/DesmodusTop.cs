public class DesmodusTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);
        Player.Sight += 2;
        Player.Lightweight += 1;
    }
    
    public override void OnUnequip()
    {
        Player.Sight -= 2;
        Player.Lightweight -= 1;
    }

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}