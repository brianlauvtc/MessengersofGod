using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class selectbutton : MonoBehaviour
{   public InventorySelect isObject;
    public Inventory Grid;
    public ShowInventoryDetail SID;
    public GameObject item_detail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void selectimage(int i)
    {
       


        if (transform.GetComponent<Image>().enabled == true)
        {
            isObject.setnum(i);
            item_detail.SetActive(true);
            SID.item = Grid.items[i];
        }
    }



}
