using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject disableGun;
    //public GameObject disableElecText, disableBulletText;
    //public GameObject disableScoreText;

    //public Image disableBulletImage;
    //public Image disableElecImage;

    public GameObject pauseCanvas;
    public GameObject gameCanvas;

    void Start()
    {
        pauseCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gamePaused = !gamePaused;

            if (gamePaused == true)
            {
                pauseCanvas.gameObject.SetActive(true);

                Time.timeScale = 0;

                gameCanvas.gameObject.SetActive(false);
                //disableScoreText.SetActive(false);

                //disableBulletImage.gameObject.SetActive(false);
                //disableElecImage.gameObject.SetActive(false);
                disableGun.SetActive(false);
                //disableElecText.SetActive(false);
                //disableBulletText.SetActive(false);
            }
            else
            {
                pauseCanvas.gameObject.SetActive(false);

                Time.timeScale = 1;

                gameCanvas.gameObject.SetActive(true);
                //disableScoreText.SetActive(true);
                //disableBulletImage.gameObject.SetActive(true);
                //disableElecImage.gameObject.SetActive(true);

                disableGun.SetActive(true);
                //disableElecText.SetActive(true);
                //disableBulletText.SetActive(true);
            }
        }

    }



}
