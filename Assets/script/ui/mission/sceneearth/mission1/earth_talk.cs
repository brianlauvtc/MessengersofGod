using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class earth_talk : MonoBehaviour
{
    public Text text;
    public int i = 0;
    public string[] introduction = new string[4];
    // Start is called before the first frame update
    void Start()
    {
        introduction[0] = "I am Darnell. My job is to manage the people in Town Earth";
        introduction[1] = "Because of the earthquake, this place become moist and appear a lot of monster.";
        introduction[2] = "Thank you!";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = introduction[i];


    }
   
}
