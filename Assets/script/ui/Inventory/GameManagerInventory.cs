using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerInventory : MonoBehaviour
{
    public Inventory inventory;
    public InventoryItem[] InventoryItemitemToAdd ;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            player.money += 850;
            inventory.AddItem(InventoryItemitemToAdd[0]);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            inventory.AddItem(InventoryItemitemToAdd[1]);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            inventory.AddItem(InventoryItemitemToAdd[2]);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            inventory.AddItem(InventoryItemitemToAdd[3]);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            inventory.AddItem(InventoryItemitemToAdd[4]);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            inventory.AddItem(InventoryItemitemToAdd[5]);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            inventory.AddItem(InventoryItemitemToAdd[6]);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            inventory.AddItem(InventoryItemitemToAdd[7]);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            inventory.AddItem(InventoryItemitemToAdd[8]);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            inventory.AddItem(InventoryItemitemToAdd[9]);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            inventory.AddItem(InventoryItemitemToAdd[10]);
        }
    }
}
