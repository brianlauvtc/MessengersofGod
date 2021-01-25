using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class armorselect : MonoBehaviour
{    public Image[] imagebg = new Image[6];
    public InventoryItem selectedimage;
    public int armorname;
    public Button takeoffbutton;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (selectedimage == null)
        {
            armorname = 8;
            takeoffbutton.gameObject.SetActive(false);

        }
        else { takeoffbutton.gameObject.SetActive(true); }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
               selectedimage = null;
        }

        for (int i = 0; i < 6; i++)
        {
            if (i == armorname)
            {
                imagebg[i].gameObject.SetActive(true);

            }
            else { imagebg[i].gameObject.SetActive(false); }
        }
    }
}
