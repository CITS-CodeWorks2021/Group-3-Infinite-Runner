using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    public ObjectPool pooler;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Vector3 newSpawnLoc = new Vector3();
            newSpawnLoc.x = transform.position.x + 20;
            pooler.SpawnRandom(newSpawnLoc);

            if (pooler.NumSpawned > 6) pooler.RemoveOldest();
        }

    }
}
