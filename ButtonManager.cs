using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject optionsPanel;
    public GameObject ShopPanel;
    public GameObject cube;
    private bool isPaused;

    //Starts Level 1
    public void PlayBtn(string playLevel)
    {
        SceneManager.LoadScene(playLevel);
        Time.timeScale = 1;
    }

    //Exit the game
    public void ExitGameBtn()
    {
        Application.Quit();
    }

    //Unpaused/Resumes the game
    public void Resume()
    {
        settingsPanel.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    //Hides the settings/puase menu & shows the options menu
    public void Options()
    {
        settingsPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    //Goes back to the settings/Pause menu
    public void backBtn()
    {
        settingsPanel.SetActive(true);
        optionsPanel.SetActive(false);
        ShopPanel.SetActive(false);
        PlayerPrefs.Save();
    }

    //Resets all playerprefs 1.Highscore 2.PlayerSkin 3.Volume settings
    public void resetHighScore()
    {
        PlayerPrefs.DeleteAll();
    }

    public void shop()
    {
        settingsPanel.SetActive(false);
        ShopPanel.SetActive(true);
        PlayerPrefs.Save();
    }

    //Toggles fullscreen on/off
    public void Fullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    //Changed cube/player colour
    public void CubeColour(Material mat)
    {
        cube.GetComponent<Renderer>().material = mat;
    }

    //When Escape is pressed, open settings menu and pause game.
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                settingsPanel.SetActive(true);
                Time.timeScale = 0;
            }
            settingsPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    private void Start()
    {
        isPaused = false;
    }
}
