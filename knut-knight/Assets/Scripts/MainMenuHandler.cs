using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    public void nextLevel() {
        SceneHandler.GetInstance().nextScene();
    }

    public void quit() {
        SceneHandler.GetInstance().Quit();
    }
}
