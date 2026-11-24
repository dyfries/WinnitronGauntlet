
using UnityEngine;


public class ProjectileSpawner : Spawner
{
    // public ForceOrientiation orientiation;
    public float defaultForce = 1f;
    public float defaultTorque = 1f;

    /*
Spawn and return the object specifying position and rotation
Use the default force and torque
  */
    public override GameObject SpawnAtLocation(Vector3 spawnPosition, Quaternion spawnRotation)
    {
        Debug.Log("Force Spawner");
        GameObject go = base.SpawnAtLocation(spawnPosition, spawnRotation);
        Rigidbody2D rb = go.GetComponent<Rigidbody2D>();

        AddTheForce(rb, defaultForce, defaultTorque);

        return go;
    }


    /*
    Spawn and return the object specifying position and rotation
    Accept and use force and torque values.
    */
    public GameObject SpawnAtLocation(Vector3 spawnPosition, Quaternion spawnRotation, float force, float torque)
    {
        GameObject go = base.SpawnAtLocation(spawnPosition, spawnRotation);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        AddTheForce(rb, force, torque);

        return go;
    }

    private void AddTheForce(Rigidbody2D rb, float force, float torque)
    {
        if (rb != null)
        {
            rb.AddForce(Vector2.right * force);
            //            rb.AddForce(new Vector2(1f, 0) * defaultForce);
            //           Vector2 myVector = new Vector2(defaultForce, 0);

        }
    }

    /*
Simple spawner you can call using Events
Uses current position and rotation of the parent spawner. 
(Note: This should also just use the SpawnAtLocation method. )
Uses the default force and torque*/
    public override void Spawn()
    {
        SpawnAtLocation(transform.position, transform.rotation);
    }

}
