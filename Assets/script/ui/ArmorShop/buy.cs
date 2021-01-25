using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buy : MonoBehaviour
{
    public AudioSource clicksound;
    public armorshopselect ass;
    public InventoryItem SelectedItem;
    public InputField inputfield;
    public int buynum;
    
    buyamount ba;
    public GameObject inventoryobject;
    Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        ba = inputfield.GetComponent<buyamount>();
        inventory = inventoryobject.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        buynum = ba.num;
        SelectedItem = ass.SelectedItem;
    }
    public void buymethod()
    {
        if (player.money >= SelectedItem.buyprice * buynum)
        {
            for (int i = 0; i < buynum; i++)
            { inventory.AddItem(SelectedItem); }
            player.money -= SelectedItem.buyprice * buynum;
            clicksound.Play(); StartCoroutine(equipment());
         
        }
    }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        clicksound.Stop();
    }
}
