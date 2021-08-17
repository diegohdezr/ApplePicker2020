using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreUI;//reference to the text in the scene

    private int score;
    private void Start()
    {
        //find the reference to the ScoreCounter game object that we have in the canvas
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        // Get the text component from that GO
        scoreUI = scoreGO.GetComponent<Text>();
        //set the starting points at 0
        scoreUI.text = "0";


    }

    // Update is called once per frame
    void Update()
    {
        //get the current screen position from the input class
        Vector3 mousePos2D = Input.mousePosition;

        //the camer's z position sets how far to push the mouse into 3D
        mousePos2D.z = -Camera.main.transform.position.z;


        //conver the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //find the object that hit this basket
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Apple") 
        {
            Destroy(collidedWith);
            //parse the text of the score UI into an int
            score = int.Parse(scoreUI.text);
            //add points for catching the apple!
            score += 100;
            //convert the score back to a string and display it!
            scoreUI.text = score.ToString();

            if (score > HighScore.score) 
            {
                HighScore.score = score;
            }
        }
    }
}
