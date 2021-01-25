using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class change_gunner : MonoBehaviour
{
    public GameObject mage;
    public GameObject shooter;
    public GameObject warrior;
    public GameObject gunner; public Text t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void change_capsule_method()
    {
        character_play.i = 4; t.text = "Introduction :\n1. Capable of using long range attacks.\n2. Use reload bullets can strengthen attack and restore mana  point.\n3. The big explosion skills can sometimes attack multiple enemies at the same time.";
        warrior.SetActive(false);
        shooter.SetActive(false);
        gunner.SetActive(true);
        mage.SetActive(false);
    }
}
