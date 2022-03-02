using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ScoreScript scoreScript;

    public Animation doorOpen;

    private GameObject doorPivot;

    void Start()
    {
        doorPivot = GameObject.Find("DoorPivot");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            scoreScript.ScoreValue += 1;
            scoreScript.score.text = "Hits: " + scoreScript.ScoreValue.ToString();
            if (scoreScript.ScoreValue == 10)
            {
                doorOpen = doorPivot.GetComponent<Animation>();
                doorOpen.Play();
            }
            Destroy(gameObject);
        }

        if (other.tag == "ElcBullet")
        {
            Destroy(other.gameObject);
        }
    }

}
