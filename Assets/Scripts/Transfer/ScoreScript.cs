using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float ScoreValue;
    public Text score;

    
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Hits: " + ScoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
