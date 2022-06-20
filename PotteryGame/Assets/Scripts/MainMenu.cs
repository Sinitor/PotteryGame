using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayLVL1()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 
    public void MainLog()
    {
        SceneManager.LoadScene(0);
    } 

    public void Stop()
    {
        Time.timeScale = 0;
    } 
    public void Play()
    {
        Time.timeScale = 1;
    }
}
