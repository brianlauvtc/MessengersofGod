using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class change_shooter : MonoBehaviour {
    public GameObject mage;
    public GameObject shooter;
    public GameObject warrior;
    public GameObject gunner; public Text t;
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}

 
    public void change_sphere_method()
    {
        character_play.i = 1; t.text = "Introduction :\n1. Proficient at bow\n2. High Agility\n3. High damage";
        shooter.SetActive(true);
        mage.SetActive(false);
        warrior.SetActive(false);
        gunner.SetActive(false);
    }
}
