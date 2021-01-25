using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buy2 : MonoBehaviour
{
    public AudioSource clicksound;
    public materialshopselect ass;
    public InventoryItem SelectedItem;
    public InputField inputfield;
    public int buynum;
    
    buyamount2 ba;
    public GameObject inventoryobject;
    Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        ba = inputfield.GetComponent<buyamount2>();
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
            player.money -= SelectedItem.buyprice * buynum;
            clicksound.Play(); StartCoroutine(equipment());
            for (int i = 0; i < buynum; i++)
            { inventory.AddItem(SelectedItem); }
        }
    }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        clicksound.Stop();
    }
}
