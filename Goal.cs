using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Text myScoretext;
    private int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.collider.name == "Ball")
        {
            other.transform.position = Vector3.zero;

            Score += 1;

            myScoretext.text = Score.ToString();

            if(Score ==2)

            {
                Application.LoadLevel("P1Win");
            }
        }
    }
}
