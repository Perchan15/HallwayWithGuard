using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public bool gamePaused = false;
    public GameObject disableGun;
    public GameObject disableElecText, disableBulletText;
    public GameObject disableScoreText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            gamePaused = !gamePaused;

            if (gamePaused == true)
            {
                Time.timeScale = 0;
                disableGun.SetActive(false);
                disableElecText.SetActive(false);
                disableBulletText.SetActive(false);
                disableScoreText.SetActive(false);

            }
            else
            {
                Time.timeScale = 1;
                disableGun.SetActive(true);
                disableElecText.SetActive(true);
                disableBulletText.SetActive(true);
                disableScoreText.SetActive(true);

            }
        }

    }



}
