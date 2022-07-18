public class GlyptodonMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Defense += 2;
        Player.Lightweight -= 2;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 2;
        Player.Lightweight += 2;
    }
}