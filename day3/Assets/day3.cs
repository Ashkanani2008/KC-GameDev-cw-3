using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class day3 : MonoBehaviour
{
    public Text scoretext;
    public int score = 0;

    int inc = 1;
    public Text inctext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void increase()
    {
        score += inc;
        scoretext.text =score.ToString();
    }
    public void shop() 
    {
        if (score >= 5) 
        {
            score -= 5;
            inc +=1;
            inctext.text = "increase =" +inc;
            scoretext.text = score.ToString();
        }

    }
}
