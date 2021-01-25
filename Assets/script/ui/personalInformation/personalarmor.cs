using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class personalarmor : MonoBehaviour
{
    public Image headpicture;
    public Image clothespicture;
    public Image shoepicture;
    public Image weaponpicture;
    public Image glovespicture;
    public Image trouserpicture;
    public int[] hp = new int[6];
    public InventoryItem[] armor = new InventoryItem[6];
    public Image[] armor_image = new Image[6];
    public InventoryItem headslot;
    public InventoryItem clothesslot;
    public InventoryItem shoeslot;
    public InventoryItem weaponslot;
    public InventoryItem glovesslot;
    public InventoryItem trouserslot;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            hp[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        armor[0] = headslot;
        armor[1] = glovesslot;
        armor[2] = clothesslot;
        armor[3] = weaponslot;
        armor[4] = trouserslot;
        armor[5] = shoeslot;

       
        if (headslot != null)
             {
                player.head_Defense = headslot.Defense_bonus;
                player.head_hp = headslot.hp_bonus;
             }
        else {
        
            player.head_Defense = 0;
            player.head_hp = 0;
        }
        if (glovesslot != null)
             {
                player.gloves_Defense = glovesslot.Defense_bonus;
                player.gloves_hp = glovesslot.hp_bonus;
             }
        else {
            player.gloves_Defense = 0;
            player.gloves_hp = 0;
        }
        if (clothesslot != null)
            {
                player.clothes_Defense = clothesslot.Defense_bonus;
                player.clothes_hp = clothesslot.hp_bonus;
            }
        else {
            player.clothes_Defense = 0;
            player.clothes_hp = 0;
        }
        if (trouserslot != null)
            {
                player.trousers_Defense = trouserslot.Defense_bonus;
                player.trousers_hp = trouserslot.hp_bonus;
            }
        else {
            player.trousers_Defense = 0;
            player.trousers_hp = 0;
        }
        if (shoeslot != null)
            {
                player.shoe_Defense = shoeslot.Defense_bonus;
                player.shoe_hp = shoeslot.hp_bonus;
            }
        else { player.shoe_Defense = 0;
               player.shoe_hp = 0;
            }

        if (weaponslot != null)
        {
            player.weapon_damage = weaponslot.damage_bonus;
        }
        else { player.weapon_damage = 0; }

        if (player.HealthPoint > player.main_Max_HealthPoint)
        {

            player.HealthPoint = player.main_Max_HealthPoint;
        }

    }

   

}
