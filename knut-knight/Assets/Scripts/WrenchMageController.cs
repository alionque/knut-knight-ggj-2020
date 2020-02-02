using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrenchMageController : MonoBehaviour
{
    public string wrenchHoriInputName;
    public string wrenchVertInputName;
    public string wrenchSpawnInputName;
    public float spd = 5f;
    // Update is called once per frame
    void Update() {
        Vector3 dir = new Vector3();
        dir.x = Input.GetAxis(wrenchHoriInputName);
        dir.y = Input.GetAxis(wrenchVertInputName);
        if (Input.GetButtonDown(wrenchSpawnInputName)) {
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
