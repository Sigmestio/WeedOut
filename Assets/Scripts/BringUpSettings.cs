using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BringUpSettings : MonoBehaviour
{
    public GameObject setting;
    public bool isSettingActive;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isSettingActive == false)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    public void Pause()
    {
        setting.SetActive(true);
        isSettingActive = true;
        this.GetComponent<MouseLook>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Resume()
    {
        setting.SetActive(false);
        isSettingActive = false;
        this.GetComponent<MouseLook>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
