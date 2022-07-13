public class EremotheriumBottom : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetBottom(BodyPart);
        Player.Defense += 1;
        Player.Lightweight -= 1;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 1;
        Player.Lightweight += 1;
    }

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}