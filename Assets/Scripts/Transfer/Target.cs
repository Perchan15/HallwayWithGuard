using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ScoreScript scoreScript;

    public Animation doorOpen;
    public AudioSource doorSound;

    private GameObject doorPivot;

    public ParticleSystem woodPoof;

    void Start()
    {
        doorPivot = GameObject.Find("DoorPivot");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {   
            Instantiate(woodPoof, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(other.gameObject);
            scoreScript.ScoreValue += 1;
            scoreScript.score.text = "Hits: " + scoreScript.ScoreValue.ToString();
            if (scoreScript.ScoreValue == 10)
            {
                doorOpen = doorPivot.GetComponent<Animation>();
                doorOpen.Play();

                doorSound = doorPivot.GetComponent<AudioSource>();
                doorSound.Play();
            }
           
        }

        if (other.tag == "ElcBullet")
        {
            Destroy(other.gameObject);
        }
    }

}
