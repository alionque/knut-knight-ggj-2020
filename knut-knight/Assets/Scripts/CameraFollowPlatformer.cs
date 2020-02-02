using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlatformer : MonoBehaviour
{
    private GameObject target;

    private void Start() {
        target = FindObjectOfType<KnutKnightController>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null) {
            return;
        }
        Vector3 newPostion = transform.position;
        newPostion.x = target.transform.position.x;
        gameObject.transform.position = newPostion;
    }
}
