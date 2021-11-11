using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void MainMenuButton() {
        SceneManager.LoadScene("Menu");
    }

    public void QuitButton() {
        Application.Quit();
    }

    public void RestartButton() {
        SceneManager.LoadScene("Main");
    }
}
