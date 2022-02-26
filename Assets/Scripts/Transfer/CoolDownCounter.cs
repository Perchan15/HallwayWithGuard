using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolDownCounter : MonoBehaviour
{
    public float BulletTimer;
    public float ElecTimer;

    public Text BulletDesplay;
    public Text ElecDesplay;

    public bool RightClick;
    public bool LeftClick;

    public bool TimerKey;
    public bool ElecTimerKey;

    // Update is called once per frame
    void Update()
    {
        //NormalBulletTimer
        BulletDesplay.text = "" + Mathf.Round(BulletTimer);

        if (LeftClick = true)
        {
            BulletTimer -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && TimerKey == true)
        {
            LeftClick = true;
            BulletTimer = 2;
        }

        if (BulletTimer <= 0)
        {
           BulletTimer = 0;
           BulletDesplay.text = "";
           LeftClick = false;
           TimerKey = true;
        }
        else if(BulletTimer > 0)
        {
            TimerKey = false;
        }

        //ElectricBulletTimer
        ElecDesplay.text = "" + Mathf.Round(ElecTimer);

        if (RightClick = true)
        {
            ElecTimer -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1) && ElecTimerKey == true)
        {
            RightClick = true;
            ElecTimer = 2;
        }

        if (ElecTimer <= 0)
        {
            ElecTimer = 0;
            ElecDesplay.text = "";
            RightClick = false;
            ElecTimerKey = true;
        }
        else if (ElecTimer > 0)
        {
            ElecTimerKey = false;
        }


    }
}
