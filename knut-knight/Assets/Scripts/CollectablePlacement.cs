using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablePlacement : MonoBehaviour
{
    public SpawnablePlatform spawnablePrefab;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag.Equals("Platformer")) {
            WrenchMageInventory.GetInstance().addItem(spawnablePrefab);
            Destroy(this.gameObject);
        }
    }
}
