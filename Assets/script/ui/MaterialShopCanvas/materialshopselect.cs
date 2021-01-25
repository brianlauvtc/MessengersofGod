using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class materialshopselect : MonoBehaviour
{
    public InventoryItem SelectedItem;
    public Image[] frameimage = new Image[9];
    public int SelectedID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SelectedItem == null)
        { SelectedID = 12; }
        if (SelectedID == 12)
        {
            for (int i = 0; i < 9; i++)
            {
                frameimage[i].gameObject.SetActive(false);
            }
        }

        for (int i = 0; i < 9; i++)
        {if (i == SelectedID)
            {
                frameimage[i].gameObject.SetActive(true);
            }
            else { frameimage[i].gameObject.SetActive(false); }

        }    
    }

    public void selectbuyitem(InventoryItem i, int num)
    {
        SelectedItem = i;
        SelectedID = num;
    }
}
