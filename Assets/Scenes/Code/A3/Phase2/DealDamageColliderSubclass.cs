using UnityEngine;

public class DealDamageColliderSubclass : DealDamageBase
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // --- Become Subclasses ---
        //This should use the Health TakeDamage method to deal damageToDeal amount of damage to the object collided with.
        TryDealDamage(collision.gameObject);
    }
}
