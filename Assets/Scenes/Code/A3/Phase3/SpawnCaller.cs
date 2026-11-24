using UnityEngine;

public class SpawnCaller : MonoBehaviour
{
    public float timer;
    public float maxTime;

    public Spawner theSpawner;

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if(timer < 0)
        {
            timer = maxTime;
            DoStuff();
        }
    }

    public void DoStuff()
    {
        //theSpawner.SpawnAtLocation(transform.position, transform.rotation);
        theSpawner.Spawn();
    }
}
