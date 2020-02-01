using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionHandler : MonoBehaviour
{
    private static SceneTransitionHandler INSTANCE;

    public static SceneTransitionHandler GetInstance() {
        return INSTANCE;
    }

    void Awake() {
        if (INSTANCE == null) {
            INSTANCE = this;
            DontDestroyOnLoad(this);
        } else {
            Destroy(this);
        }
    }

    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }

    public void LoadScene(int index) {
        SceneManager.LoadScene(index);
    }
}
