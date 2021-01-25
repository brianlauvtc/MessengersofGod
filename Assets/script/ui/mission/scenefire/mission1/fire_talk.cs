using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class fire_talk : MonoBehaviour
{
    public Text text;
    public int i = 0;
    public string[] introduction = new string[8];
    // Start is called before the first frame update
    void Start()
    {
        introduction[1] = "This plant is called Pluto where builded by Anunaci. There has a town that we called Shengwang Town. Anunaci use high-tech technology to build Shengwang Town.";
        introduction[2] = "Two years ago,  a giant meteorite fell on Pluto. The impact of the meteorite caused a serious earthquake. The shock caused by the earthquake caused Pluto to move in the crust";
        introduction[3] = "Shengwang Town and the surrounding environment split into four continents. The four-element crystal does not catch the ground, so it is separated by the movement of the floor.";
        introduction[4] = "Shengwang Town is divided into 4 towns. Pluto temporarily named 4 towns as Town Fire, Town Water, Town Earth and Town Ice.";
        introduction[5] = "Due to the distance of the four-element crystal, Pluto is in great confusion. he energy of various elemental crystals changes the environment nearby.";
        introduction[6] = "All continents have mutated creatures because of the energy of elemental crystals and the various crystals are transformed into different giant monsters. They attack the Pluto and plunder the life of the Pluto.";

    }

    // Update is called once per frame
    void Update()
    {
        introduction[0] = "Hello! " + player.player_name +
            ". My name is Jarvis. I am the Head in this town. May I tell you something what happened in this town?";
        introduction[7] = player.player_name + "! You are our the only hope. Please help us to defeat the monster to save our world!";
        text.text = introduction[i];


    }
   
}
