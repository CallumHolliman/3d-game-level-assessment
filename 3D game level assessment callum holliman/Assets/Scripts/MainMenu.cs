using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayButton() {
        SceneManager.LoadScene("Main");
    }

    public void QuitButton() {
        Application.Quit();
    }

    public void QualityLow() {
        QualitySettings.SetQualityLevel(0);
    }

    public void QualityMedium() {
        QualitySettings.SetQualityLevel(2);
    }

    public void QualityHigh() {
        QualitySettings.SetQualityLevel(4);
    }

    public void FullscreenToggle() {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
