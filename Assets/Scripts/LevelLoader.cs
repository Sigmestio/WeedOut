using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void Level()
    {
        SceneManager.LoadScene("lvl");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
