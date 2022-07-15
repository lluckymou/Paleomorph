public class GlyptodonMiddle : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetMiddle(BodyPart);
        Player.Defense += 1;
        Player.Lightweight -= 1;
    }
    
    public override void OnUnequip()
    {
        Player.Defense -= 1;
        Player.Lightweight += 1;
    }
}