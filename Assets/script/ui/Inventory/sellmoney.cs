using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class sellmoney : MonoBehaviour
{
    public AudioSource clicksound;
    public GameObject sellcanvas;
    public InputField inputfield;
    public GameObject inventoryobject;
    InventorySelect Is;
    sell s;
    public Inventory inventory;
    public int selectedobject;
    // Start is called before the first frame update
    void Start()
    {
        s = inputfield.GetComponent<sell>();
        Is = inventoryobject.GetComponent<InventorySelect>();
       
    }

    // Update is called once per frame
    void Update()
    {
 
        selectedobject = Is.selectnum;
    }

    public void sell()
    {
        if (inventory.items[selectedobject].Type != type.crystal)
        { 
            player.money += (inventory.items[selectedobject].sell_price * s.num);
        clicksound.Play(); StartCoroutine(equipment());
        for (int i = 0; i < s.num; i++)
        { inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); }
        sellcanvas.SetActive(false);
    }
        if (inventory.itemCount[selectedobject] == 0) Is.selectedimage = null;

    }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        clicksound.Stop();
    }

}
