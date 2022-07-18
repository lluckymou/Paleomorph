using UnityEngine;

public class VinctiferTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);

        Vector3 size = Player.instance.gameObject.GetComponent<BoxCollider>().size;
        size.z = 3f;
        Player.instance.gameObject.GetComponent<BoxCollider>().size = size;

        Player.AquaticAffinity += 2;
        Player.Sight -= 2;
    }
    
    public override void OnUnequip()
    {
        Vector3 size = Player.instance.gameObject.GetComponent<BoxCollider>().size;
        size.z = 1;
        Player.instance.gameObject.GetComponent<BoxCollider>().size = size;
        
        Player.AquaticAffinity -= 2;
        Player.Sight += 2;
    }
}