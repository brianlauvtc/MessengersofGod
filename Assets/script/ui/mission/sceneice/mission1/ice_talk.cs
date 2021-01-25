using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ice_talk : MonoBehaviour
{
    public Text text;
    public int i = 0;
    public string[] introduction = new string[7];
    // Start is called before the first frame update
    void Start()
    {
        introduction[1] = "The most dangerous place in this plant is here.";
        introduction[2] = "The crystal spawn a lot of monster. And the crystal is the key to save this plant.";
        introduction[3] = "OK, now you have the three crystal. Fire Crystal, Water Crystal, and Earth Crystal.";
        introduction[4] = "All you need to do is to get the last crystal, Ice Crystal. If you get the crystal, the plant will revert to the original state";
        introduction[5] = "We will give you some suggestion step. Please follow my suggestion to kill the monster. It should be the most safest way to kill the monster.";

    }

    // Update is called once per frame
    void Update()
    {
        introduction[0] = "Welcome! " + player.player_name +
            ". I am Verne. The leader of Ice twon is me. ";
      
        text.text = introduction[i];


    }
   
}
