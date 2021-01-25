using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryLoad : MonoBehaviour
{
    public Inventory invent;
    public hotkeylist hkl;
    public personalarmor pr;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 21; i++)
        {
            invent.itemCount[i] = InventoryToNextScene.itemCount[i];
            invent.items[i] = InventoryToNextScene.items[i];
            if (invent.items[i] != null)
            {
                invent.itemImages[i].sprite = InventoryToNextScene.items[i].sprite;
                invent.itemImages[i].name = InventoryToNextScene.items[i].Itemname + " = " + InventoryToNextScene.itemCount[i].ToString();
                invent.itemImages[i].enabled = true;
                if (invent.itemCount[i] <= 99)
                { invent.counts[i].text = invent.itemCount[i].ToString(); }
                else { invent.counts[i].text = "99+"; }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            hkl.num[i] = InventoryToNextScene.itemCount_inhotkey[i];
            hkl.item[i] = InventoryToNextScene.items_inhotkey[i];
            if (hkl.item[i] != null)
            { hkl.image[i].GetComponent<Image>().enabled = true;
                if (hkl.num[i] <= 99)
                { hkl.count[i].text = hkl.num[i].ToString(); }
                else { hkl.count[i].text = "99+"; }
                hkl.image[i].GetComponent<Image>().sprite = InventoryToNextScene.items_inhotkey[i].sprite;
            }

        }
        for (int i = 0; i < 6; i++)
        {    if (i == 0)
            {
                pr.headslot = InventoryToNextScene.armor[i];
                if (pr.headslot != null)
                {
                    pr.headpicture.sprite = InventoryToNextScene.armor[i].sprite;
                    pr.headpicture.name = "headImage = " + InventoryToNextScene.armor[i].Itemname;
                    pr.headpicture.enabled = true;
                }
            }
            if (i == 1)
            {
                pr.glovesslot = InventoryToNextScene.armor[i];
                if (pr.glovesslot != null)
                {
                    pr.glovespicture.sprite = InventoryToNextScene.armor[i].sprite;
                    pr.glovespicture.name = "headImage = " + InventoryToNextScene.armor[i].Itemname;
                    pr.glovespicture.enabled = true;
                }
            }
            if (i ==2)
            {
                pr.clothesslot = InventoryToNextScene.armor[i];
                if (pr.clothesslot != null)
                {
                    pr.clothespicture.sprite = InventoryToNextScene.armor[i].sprite;
                    pr.clothespicture.name = "headImage = " + InventoryToNextScene.armor[i].Itemname;
                    pr.clothespicture.enabled = true;
                }
            }
            if (i == 3)
            {
                pr.weaponslot = InventoryToNextScene.armor[i];
                if (pr.weaponslot != null)
                {
                    pr.weaponpicture.sprite = InventoryToNextScene.armor[i].sprite;
                    pr.weaponpicture.name = "headImage = " + InventoryToNextScene.armor[i].Itemname;
                    pr.weaponpicture.enabled = true;
                }
            }
            if (i == 4)
            {
                pr.trouserslot = InventoryToNextScene.armor[i];
                if (pr.trouserslot != null)
                {
                    pr.trouserpicture.sprite = InventoryToNextScene.armor[i].sprite;
                    pr.trouserpicture.name = "headImage = " + InventoryToNextScene.armor[i].Itemname;
                    pr.trouserpicture.enabled = true;
                }
            }
            if (i == 5)
            {
                pr.shoeslot = InventoryToNextScene.armor[i];
                if (pr.shoeslot != null)
                {
                    pr.shoepicture.sprite = InventoryToNextScene.armor[i].sprite;
                    pr.shoepicture.name = "headImage = " + InventoryToNextScene.armor[i].Itemname;
                    pr.shoepicture.enabled = true;
                }
            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
