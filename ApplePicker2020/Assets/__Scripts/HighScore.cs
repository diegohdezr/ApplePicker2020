using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    public static int score = 1000;



    private void Awake()
    {
        if (PlayerPrefs.HasKey("HighScore")) 
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text hScoreText = this.GetComponent<Text>();
        hScoreText.text = "High Score: " + score;
        //actualizar los playerprefs con el HS si es necesario
        if (score > PlayerPrefs.GetInt("HighScore")) 
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
