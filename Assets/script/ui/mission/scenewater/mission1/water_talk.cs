using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class water_talk : MonoBehaviour
{
    public Text text;
    public int i = 0;
    public string[] introduction = new string[3];
    // Start is called before the first frame update
    void Start()
    {
        introduction[0] = "Oh! You are the hero! Jarvis told me that you save their town. Let's introduce myself. My name is Abner. I am the leader of Town Water";
        introduction[1] = "My people got some trouble form the monster. Please help them to solve the problem. ";
        introduction[2] = "Thank you for that!";
        

    }

    // Update is called once per frame
    void Update()
    {
     
        text.text = introduction[i];


    }
   
}
