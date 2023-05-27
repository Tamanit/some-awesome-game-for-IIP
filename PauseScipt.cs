using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScipt : MonoBehaviour
{
    public GameObject _pauseMenu;
    public GameObject _controls;
    private bool IsPaused = false;
    
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) SetPause();
    }

    public void SetPause()
    {
        IsPaused = !IsPaused;
        _pauseMenu.SetActive(IsPaused);
        Time.timeScale = IsPaused ? 0 : 1;
    }

    public void GoToMenu()
    {
        Time.timeScale =  1;
        SceneManager.LoadScene("menu");
    }
    
    public void Restart()
     => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    public void CloseOpenControls()
        => _controls.SetActive(!_controls.activeSelf);
}
