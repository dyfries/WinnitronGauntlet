using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class DealDamage : MonoBehaviour
{
    [SerializeField]
    private float damageToDeal = 1f;
    public bool healMode = false;

    //This should use the Health TakeDamage method to deal damageToDeal amount of damage to the object collided with.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Health h = collision.gameObject.GetComponent<Health>();

        ManageHP(h);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health h = collision.gameObject.GetComponent<Health>();

        ManageHP(h);
    }

    private void ManageHP(Health contactedHealth)
    {
        
        if (contactedHealth != null)
        {
            if (healMode)
            {
                contactedHealth.HealDamage(damageToDeal);
            }
            else
            {
                contactedHealth.TakeDamage(damageToDeal);
            }
        }
    }

    public void SetNewDamage(float damageAmount)
    {
        damageToDeal = damageAmount;
    }

}
