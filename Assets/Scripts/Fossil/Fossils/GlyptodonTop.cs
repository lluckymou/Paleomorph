using UnityEngine;

public class GlyptodonTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);
        
        Vector3 size = Player.instance.gameObject.GetComponent<BoxCollider>().size;
        size.z = 4.5f;
        Player.instance.gameObject.GetComponent<BoxCollider>().size = size;

        Player.Defense += 2;
        Player.Sight -= 2;
    }
    
    public override void OnUnequip()
    {
        Vector3 size = Player.instance.gameObject.GetComponent<BoxCollider>().size;
        size.z = 1;
        Player.instance.gameObject.GetComponent<BoxCollider>().size = size;
        
        Player.Defense -= 2;
        Player.Sight += 2;
    }
}