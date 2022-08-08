using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script4 : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text incText;

    public int inc = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void scoreUP()
    {
        score += inc;
        scoreText.text = score.ToString();
    }

      public void store()
    {
        if(score >= 3)
        {
            score -= 3;
            inc += 1;
            scoreText.text = score.ToString();
            incText.text = "Inc: " + inc; 

        }
    }

}
