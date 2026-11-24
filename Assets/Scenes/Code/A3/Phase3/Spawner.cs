
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    protected GameObject lastSpawnedObject;

    
    public virtual GameObject SpawnAtLocation(Vector3 spawnPosition, Quaternion spawnRotation)
    {
        lastSpawnedObject = Instantiate(prefab, spawnPosition, spawnRotation);
        return lastSpawnedObject;
    }


// Spawn and return the object specifying position and rotation
// Store the object reference in lastSpawnedObject
    public virtual void Spawn()
    {
        SpawnAtLocation(transform.position, transform.rotation);
    }



}
