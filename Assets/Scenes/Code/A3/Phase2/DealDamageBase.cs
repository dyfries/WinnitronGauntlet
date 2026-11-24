using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public abstract class DealDamageBase : MonoBehaviour
{
    [SerializeField]
    protected float damageToDeal = 1f;

    [SerializeField]
    protected bool healMode = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        TryDealDamage(collision.gameObject);
    }

    /*
    Should check whether the object has a health script.If so , call its TakeDamage method, passing it the damageValue
    Returns true if it executed, finding a listener and calling the script, return false if it doesn’t.
    Note: You could use TryGetComponent<Health> or GetComponent<Health> then check if it was null. 
    */
    protected bool TryDealDamage(GameObject target)
    {
        bool returnVal = false;

        Health h = target.GetComponent<Health>();

        if(h != null)
        {
            ManageHP(h);
            returnVal = true;
        }

        return returnVal;
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
        Debug.Log("Someone is changing the amage to " + damageAmount);

        damageToDeal = damageAmount;

        if(damageAmount < 0)
        {
            damageAmount = 0;
            Debug.LogWarning("Someone tried to set this negative");
        }
    }

}
