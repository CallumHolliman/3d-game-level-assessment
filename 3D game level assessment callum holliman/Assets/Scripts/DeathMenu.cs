using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    private void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void MainMenuButton() {
        SceneManager.LoadScene("Menu");
    }

    private void QuitButton() {
        Application.Quit();
    }

    private void RestartButton() {
        SceneManager.LoadScene("Main");
    }
}
