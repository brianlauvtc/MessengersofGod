using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sell : MonoBehaviour
{
    public GameObject inventoryobject;
    InventorySelect Is;
    public Inventory inventory;

   public InputField inputfield;
   public int num;
 
    // Start is called before the first frame update
    void Start()
    {
        Is = inventoryobject.GetComponent<InventorySelect>();
        num = 1;
    }

    // Update is called once per frame
    void Update()
    {
        inputfield.text = num.ToString();
    }
    
    public void plus()
    {if (num < inventory.itemCount[Is.selectnum])
        { num++; }
    }

    public void minus() {
        if (num > 1)
        { num--; }
    }
}
