using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class change_mage : MonoBehaviour {
    public GameObject mage;
    public GameObject shooter;
    public GameObject warrior;
    public GameObject gunner;
    public Text t;
    // Use this for initialization
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
     
    }
    public void change_cube_method()
    {
        character_play.i = 3;
        t.text = "Introduction :\n1. A magician who knows how to use spell attacks\n2. Can even use magic to restore life and strengthen attacks in an emergency.\n3. Can use laser to make long-distance damage.";
        mage.SetActive(true);
        shooter.SetActive(false);
        warrior.SetActive(false);
        gunner.SetActive(false);
    }
}
