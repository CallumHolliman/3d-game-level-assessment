using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    private void PlayButton() {
        SceneManager.LoadScene("Main");
    }

    private void QuitButton() {
        Application.Quit();
    }

    private void QualityLow() {
        QualitySettings.SetQualityLevel(0);
    }

    private void QualityMedium() {
        QualitySettings.SetQualityLevel(2);
    }

    private void QualityHigh() {
        QualitySettings.SetQualityLevel(4);
    }

    private void FullscreenToggle() {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
