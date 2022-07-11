using UnityEngine;

public class VinctiferTop : Fossil
{
    public override void OnEquip()
    {
        Player.instance.SetTop(BodyPart);

        Vector3 size = Player.instance.gameObject.GetComponent<BoxCollider>().size;
        size.z = 3f;
        Player.instance.gameObject.GetComponent<BoxCollider>().size = size;

        // Player.AquaticAffinity += 5;
    }
    
    public override void OnUnequip()
    {
        Vector3 size = Player.instance.gameObject.GetComponent<BoxCollider>().size;
        size.z = 1;
        Player.instance.gameObject.GetComponent<BoxCollider>().size = size;
        
        // Player.AquaticAffinity -= 5;
    }

    public override void OnScoring() {}

    public override void OnDeath() {}

    public override void OnCollision() {}
}