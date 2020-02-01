using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrenchMageController : MonoBehaviour
{
    public string wrenchHoriInputName;
    public string wrenchVertInputString;
    public float spd = 5f;
    // Update is called once per frame
    void Update()
    {
        Vector3 dir = new Vector3();
        dir.x = 0; //Replace w a remote horizontal check
        dir.y = 0; //Replace w a remote vertical check
        if (false) { //Check for place button pressed
            maybeUseSpawnableObject();
        }

        transform.position += dir * spd * Time.deltaTime; //Chose not to use rigid body to allow for tighter movements.
    }

    private void maybeUseSpawnableObject() {
       SpawnablePlatform platform = WrenchMageInventory.GetInstance().GetSpawnablePlatform();

        if(platform != null) {
            Instantiate(platform, transform.position, Quaternion.identity);
        }
    }
}
