using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //[SerializeField] private string LoadScene;
    public void NewGame()
    {
        SceneManager.LoadScene("City");
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
