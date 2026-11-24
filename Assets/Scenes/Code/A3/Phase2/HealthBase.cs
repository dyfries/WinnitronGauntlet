using UnityEngine;

using UnityEngine.Events;

public class HealthBase : MonoBehaviour
{
    public UnityEvent OnTakeDamage = new UnityEvent();
    public UnityEvent OnHealingDamage = new UnityEvent();
    public UnityEvent OnDeath = new UnityEvent();

    [SerializeField]
    private float currentHealth;
    public float maxHealth;


    //Just use this to set the currentHealth to maxHealth
    public void TakeDamage(float damageTaken)
    {
        currentHealth = currentHealth - damageTaken;

        OnTakeDamage.Invoke();

        if (currentHealth < 0)
        {
            Death();
        }
    }

    //If current health < 0, call Death method
    //damageTaken parameter should be a positive value, use absolute value to ensure negative values don’t get through.Throw a warning if the value is negative.
    public void HealDamage(float damageHealed)
    {
        currentHealth = currentHealth + damageHealed;

        OnHealingDamage.Invoke();

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    //Should be a positive value, use absolute value to ensure negative values don’t get through.Throw a warning if the value is negative.
    //Can’t be above max.
    private void Death()
    {
        //For now just call the OnDeath Event
        //Note: There are a few ways to handle death, you could disable this script, include a bool isDead, or rely on the events.It just depends on the context and your game.You don’t have to do that right now though.  
        OnDeath.Invoke();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
