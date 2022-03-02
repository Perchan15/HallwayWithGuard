using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public Button startButton;
    public Button aboutButton;
    public Button exitButton;

    public Button backButton;

    public Text controlText;
    public Text controlButtonsText;
    public Text creditsText;
    public Text creditsNamesText;
    public Text objective;
    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartClick);
        aboutButton.onClick.AddListener(AboutClick);
        exitButton.onClick.AddListener(ExitClick);
        backButton.onClick.AddListener(BackClick);

        backButton.gameObject.SetActive(false);

        controlText.gameObject.SetActive(false);
        controlButtonsText.gameObject.SetActive(false);
        creditsText.gameObject.SetActive(false);
        creditsNamesText.gameObject.SetActive(false);
        objective.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void StartClick()
    {
        Debug.Log ("You have clicked start");
        SceneManager.LoadScene("Gameplay");
    }

    void AboutClick()
    {
        Debug.Log ("You have clicked about");
        backButton.gameObject.SetActive(true);

        startButton.gameObject.SetActive(false);
        aboutButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);

        controlText.gameObject.SetActive(true);
        controlButtonsText.gameObject.SetActive(true);
        creditsText.gameObject.SetActive(true);
        creditsNamesText.gameObject.SetActive(true);
        objective.gameObject.SetActive(true);
    }

    void ExitClick()
    {
        Debug.Log ("You have clicked exit");
        Application.Quit();
    }

    void BackClick()
    {
        backButton.gameObject.SetActive(false);

        controlText.gameObject.SetActive(false);
        controlButtonsText.gameObject.SetActive(false);
        creditsText.gameObject.SetActive(false);
        creditsNamesText.gameObject.SetActive(false);
        objective.gameObject.SetActive(false);

        startButton.gameObject.SetActive(true);
        aboutButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
    }
}
