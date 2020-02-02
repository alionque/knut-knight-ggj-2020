using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    private static SceneHandler INSTANCE;

    public static SceneHandler GetInstance() {
        return INSTANCE;
    }

    void Awake() {
        if (INSTANCE == null) {
            INSTANCE = this;
            DontDestroyOnLoad(this.gameObject);
        } else {
            Destroy(this);
        }
    }

    public void nextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void restartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }

    public void LoadScene(int index) {
        SceneManager.LoadScene(index);
    }

    public void Quit() {
        Application.Quit();
    }
}
