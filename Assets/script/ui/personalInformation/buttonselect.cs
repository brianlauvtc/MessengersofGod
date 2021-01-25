using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonselect : MonoBehaviour
{
    public GameObject Grid;
    public GameObject person;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void select(int arname) {
        if (transform.GetComponent<Image>().enabled == true)
        { Grid.GetComponent<armorselect>().selectedimage = person.GetComponent<personalarmor>().armor[arname]; Grid.GetComponent<armorselect>().armorname = arname; }
    
    }
}
