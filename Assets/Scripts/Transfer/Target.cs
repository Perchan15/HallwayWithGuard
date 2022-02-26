using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ScoreScript scoreScript;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            scoreScript.ScoreValue += 1;
            scoreScript.score.text =scoreScript.ScoreValue.ToString();
            Destroy(gameObject);
        }

        if (other.tag == "ElcBullet")
        {
            Destroy(other.gameObject);
        }
    }

}
