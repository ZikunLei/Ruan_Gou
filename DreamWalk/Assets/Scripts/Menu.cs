using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioMixer audioMixer;

    //开始游戏
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    //退出游戏
    public void QuitGame()
    {
        Application.Quit();
    }

}
