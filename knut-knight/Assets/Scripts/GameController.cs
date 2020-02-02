using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startLevel());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator startLevel() {
        yield return new WaitForSecondsRealtime(3f);
        DragonController.START_THE_DRAGON();
    }
}
