using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public int MaxLevels = 3;

    public void LoadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("I want quit.");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(3);

        Scene scene = SceneManager.GetActiveScene();
        string sceneName = scene.name;
        int sceneIndex = int.Parse(sceneName.Split('_')[1]);

        if (sceneIndex < MaxLevels)
        {
            SceneManager.LoadScene(string.Format("Level_{0:D2}",sceneIndex + 1));
        }
        else
        {
            SceneManager.LoadScene("Info");
        }
    }

    public void BrickDestroyed()
    {
        if(Brick.breakableCount <= 0)
        {
            LoadNextLevel();
        }
    }
}
