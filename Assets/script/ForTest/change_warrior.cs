using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class change_warrior : MonoBehaviour {
    public GameObject mage;
    public GameObject shooter;
    public GameObject warrior;
    public GameObject gunner; public Text t;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void change_capsule_method()
    {
        character_play.i = 2;
        t.text = "Introduction :\n1. Proficient at sword\n2. High Health Point\n3. The skills are rage attack";
        warrior.SetActive(true);
        shooter.SetActive(false);
        gunner.SetActive(false);
        mage.SetActive(false);
    }


}
