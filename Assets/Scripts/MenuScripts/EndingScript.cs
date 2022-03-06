using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndingScript : MonoBehaviour
{
    public Button menuButton;
    public Button exitButton;

    public Text endingText;

    public static bool Winner;
    
    // Start is called before the first frame update
    void Start()
    {
        menuButton.onClick.AddListener(MenuClick);
        exitButton.onClick.AddListener(ExitClick);

        if(Winner == true)
        {
            endingText.text = "Complete";
        }
        else
        {
            endingText.text = "<i>\"Why did you do it?\"</i>";
        }
    }

    // Update is called once per frame
    void MenuClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void ExitClick()
    {
        Debug.Log ("You have clicked exit");
        Application.Quit();
    }
}
