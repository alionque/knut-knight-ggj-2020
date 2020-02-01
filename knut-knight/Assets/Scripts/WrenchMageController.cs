using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrenchMageController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3();
        vel.x = 0; //Replace w a remote horizontal check
        vel.y = 0; //Replace w a remote vertical check
        if (false) { //Check for place button pressed
            maybeUseSpawnableObject();
        }

        transform.position += vel * Time.deltaTime; //Chose not to use rigid body to allow for tighter movements.
    }

    private void maybeUseSpawnableObject() {
       SpawnablePlatform platform = WrenchMageInventory.GetInstance().GetSpawnablePlatform();

        if(platform != null) {
            Instantiate(platform, transform.position, Quaternion.identity);
        }
    }
}
