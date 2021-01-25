using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class useitem : MonoBehaviour
{
    public GameObject inventoryobject, missionobject;
    InventorySelect Is;
    Inventory inventory;
    public int selectedobject;
    public GameObject personal;
    public GameObject cannotUseMissionCrystal;
    public GameObject cannotuse;
    personalarmor Ppersonalarmor;
    public Text t, t2;
    public AudioSource hpsound, mpsound, equipmentsound ,   weaponsound;
    // Start is called before the first frame update
    void Start()
    {
        inventory = missionobject.GetComponent<Inventory>();
        Is = inventoryobject.GetComponent<InventorySelect>();
        Ppersonalarmor = personal.GetComponent<personalarmor>();
    }

    // Update is called once per frame
    void Update()
    {
        selectedobject = Is.selectnum;
        

    }
    

    public void use()
    {
        if (inventory.items[selectedobject].Type == type.crystal || inventory.items[selectedobject].Type == type.missionobject)
        { cannotUseMissionCrystal.SetActive(true); }


            if (inventory.items[selectedobject].Type == type.prop)
        {
           
            if (inventory.items[selectedobject].Restoretype == restoretype.hp)
            {
                if ((player.main_Max_HealthPoint - player.HealthPoint) >= 20)
                {
                    hpsound.Play();
                    StartCoroutine(hp());
                    if (inventory.itemCount[selectedobject] == 0)
                    { Is.selectedimage = null; }
                    player.HealthPoint += inventory.items[selectedobject].restore;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum);

                }
            }
            if (inventory.items[selectedobject].Restoretype == restoretype.mp)
            {
                if ((player.main_Max_ManaPoint - player.ManaPoint) >= 20)
                {
                    mpsound.Play();
                    StartCoroutine(mp());
                   
                    if (inventory.itemCount[selectedobject] == 0)
                    { Is.selectedimage = null; }
                    player.ManaPoint += inventory.items[selectedobject].restore;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum);

                }


            }


        }

        if (inventory.items[selectedobject].Type == type.equipment)
        {
            equipmentsound.Play();
            StartCoroutine(equipment());
            if (inventory.items[selectedobject].Equipmenttype == equipmenttype.head)
            {

            
                if (Ppersonalarmor.headslot == null)
                {
                 
                 
                    Ppersonalarmor.headslot = inventory.items[selectedobject];
                    Ppersonalarmor.headpicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.headpicture.name = "headImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.headpicture.enabled = true; 
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum);  Is.selectedimage = null;

                } else
                {
                   
                    inventory.AddItem(Ppersonalarmor.headslot);

                    Ppersonalarmor.headslot = inventory.items[selectedobject];
                    Ppersonalarmor.headpicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.headpicture.name = "headImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.headpicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                }


            }
            else { print("ahead"); }
            if (inventory.items[selectedobject].Equipmenttype == equipmenttype.clothes)
            {
              
              
                if (Ppersonalarmor.clothesslot == null)
                {
               
                    Ppersonalarmor.clothesslot = inventory.items[selectedobject];
                    Ppersonalarmor.clothespicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.clothespicture.name = "clothesImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.clothespicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;

                }
                else
                {
                    inventory.AddItem(Ppersonalarmor.clothesslot);
              
                    Ppersonalarmor.clothesslot = inventory.items[selectedobject];
                    Ppersonalarmor.clothespicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.clothespicture.name = "clothesImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.clothespicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                }

            }
            if (inventory.items[selectedobject].Equipmenttype == equipmenttype.gloves)
            {
             
                if (Ppersonalarmor.glovesslot == null)
                {
                

                    Ppersonalarmor.glovesslot = inventory.items[selectedobject];
                    Ppersonalarmor.glovespicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.glovespicture.name = "glovesImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.glovespicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;

                }
                else
                {
                    inventory.AddItem(Ppersonalarmor.glovesslot);
          
                    Ppersonalarmor.glovesslot = inventory.items[selectedobject];
                    Ppersonalarmor.glovespicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.glovespicture.name = "glovesImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.glovespicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                }
            }
            if (inventory.items[selectedobject].Equipmenttype == equipmenttype.shoe)
            {
           
                if (Ppersonalarmor.shoeslot == null)
                {
                

                    Ppersonalarmor.shoeslot = inventory.items[selectedobject];
                    Ppersonalarmor.shoepicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.shoepicture.name = "shoeImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.shoepicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;

                }
                else
                {
                    inventory.AddItem(Ppersonalarmor.shoeslot);
                    
                    Ppersonalarmor.shoeslot = inventory.items[selectedobject];
                    Ppersonalarmor.shoepicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.shoepicture.name = "shoeImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.shoepicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                }

            }
            if (inventory.items[selectedobject].Equipmenttype == equipmenttype.trouser)
            {
             
                if (Ppersonalarmor.trouserslot == null)
                {
                   
                    Ppersonalarmor.trouserslot = inventory.items[selectedobject];
                    Ppersonalarmor.trouserpicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.trouserpicture.name = "trouserImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.trouserpicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;

                }
                else
                {
                    inventory.AddItem(Ppersonalarmor.trouserslot);
                
                    Ppersonalarmor.trouserslot = inventory.items[selectedobject];
                    Ppersonalarmor.trouserpicture.sprite = inventory.items[selectedobject].sprite;
                    Ppersonalarmor.trouserpicture.name = "trouserImage = " + inventory.items[selectedobject].Itemname;
                    Ppersonalarmor.trouserpicture.enabled = true;
                    inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                }
            }
           

        }
        if (inventory.items[selectedobject].Type == type.weapon)
        {
           
            if (inventory.items[selectedobject].Weapontype == weapontype.bow)
            {
                if (character_play.i == 1)
                {
                    weaponsound.Play();
                    StartCoroutine(weapon());
                    if (Ppersonalarmor.weaponslot == null)
                    {
                      
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;

                    }
                    else
                    {
                        inventory.AddItem(Ppersonalarmor.weaponslot);
                      
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                    }
                }



                if (character_play.i == 2) { t.text = "Bow is not suitable for you."; t2.text = "Please use Broadsword."; cannotuse.SetActive(true); }
                if (character_play.i == 3) { t.text = "Bow is not suitable for you."; t2.text = "Please use Wand."; cannotuse.SetActive(true); }
                if (character_play.i == 4) { t.text = "Bow is not suitable for you."; t2.text = "Please use Gun."; cannotuse.SetActive(true); }


            }
            if (inventory.items[selectedobject].Weapontype == weapontype.Broadsword)
            {
                if (character_play.i == 1) { t.text = "Broadsword is not suitable for you."; t2.text = "Please use Bow."; cannotuse.SetActive(true); }


                if (character_play.i == 2)
                {
                    weaponsound.Play();
                    StartCoroutine(weapon());
                    if (Ppersonalarmor.weaponslot == null)
                    {
                        
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum);
                        Is.selectedimage = null;
                    }
                    else
                    {
                        inventory.AddItem(Ppersonalarmor.weaponslot);
                      
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum);
                        Is.selectedimage = null;
                    }
                }


                if (character_play.i == 3) { t.text = "Broadsword is not suitable for you."; t2.text = "Please use Wand."; cannotuse.SetActive(true); }
                if (character_play.i == 4) { t.text = "Broadsword is not suitable for you."; t2.text = "Please use Gun."; cannotuse.SetActive(true); }

            }
            if (inventory.items[selectedobject].Weapontype == weapontype.gun)
            {
                if (character_play.i == 1) { t.text = "Gun is not suitable for you."; t2.text = "Please use Bow."; cannotuse.SetActive(true); }
                if (character_play.i == 2) { t.text = "Gun is not suitable for you."; t2.text = "Please use Broadsword."; cannotuse.SetActive(true); }
                if (character_play.i == 3) { t.text = "Gun is not suitable for you."; t2.text = "Please use Wand."; cannotuse.SetActive(true); }


                if (character_play.i == 4)
                {
                    weaponsound.Play();
                    StartCoroutine(weapon());
                    if (Ppersonalarmor.weaponslot == null)
                    {
                       
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;

                    }
                    else
                    {
                        inventory.AddItem(Ppersonalarmor.weaponslot);
                      
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                    }
                }
            }
            if (inventory.items[selectedobject].Weapontype == weapontype.wand)
            {
                if (character_play.i == 1) { t.text = "Wand is not suitable for you."; t2.text = "Please use Bow."; cannotuse.SetActive(true); }
                if (character_play.i == 2) { t.text = "Wand is not suitable for you."; t2.text = "Please use Broadsword."; cannotuse.SetActive(true); }
                if (character_play.i == 3)
                {
                    weaponsound.Play();
                    StartCoroutine(weapon());
                    if (Ppersonalarmor.weaponslot == null)
                    {
                      
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;

                    }
                    else
                    {
                        inventory.AddItem(Ppersonalarmor.weaponslot);
                      
                        Ppersonalarmor.weaponslot = inventory.items[selectedobject];
                        Ppersonalarmor.weaponpicture.sprite = inventory.items[selectedobject].sprite;
                        Ppersonalarmor.weaponpicture.name = "weaponImage = " + inventory.items[selectedobject].Itemname;
                        Ppersonalarmor.weaponpicture.enabled = true;
                        inventory.RemoveItem(inventory.items[selectedobject], Is.selectnum); Is.selectedimage = null;
                    }
                }

                if (character_play.i == 4) { t.text = "Wand is not suitable for you."; t2.text = "Please use Gun."; cannotuse.SetActive(true); }

            }

        }


    }
    IEnumerator hp()
    {
        yield return new WaitForSeconds(1f);
        hpsound.Stop();
    }
    IEnumerator mp()
    {
        yield return new WaitForSeconds(1f);
        mpsound.Stop();
    }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        equipmentsound.Stop();
    }
  
    
    
    
    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        weaponsound.Stop();
    }
}
