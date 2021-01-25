using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monsterdrop : MonoBehaviour
{
    public Inventory inventorygrids;
    public InventoryItem[] potionlist = new InventoryItem[2];
    public InventoryItem[] equipmentlist = new InventoryItem[3];
    public Text potiontext;
    
   // public GameObject Inventory_canvas;
    public string name2;
    public Text equipmenttext;
    public int randomDroppotion;
    public int randomDropequipment;

    public bool mission;
    public string scenename;
    public int missionnum;
    public fire_mission3_add fm3a;
    public water_mission4_add wm4a;
    public earth_mission2_add em2a;
    public earth_mission5_add em5a;
    public ice_mission4_add im4a;
    public fire_mission3 fm3;
    public water_mission4 wm4;
    public earth_mission2 em2;
    public earth_mission5 em5;
    public ice_mission4 im4;

    public int randomDropmission;
    public InventoryItem missionitem;
    public Text missiontext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inventory_canvas = GameObject.FindGameObjectWithTag("inventory");
    }
    public void drop(string name)
    {
       
        
        randomDroppotion = UnityEngine.Random.Range(1, 11);
        if (randomDroppotion >= 3 && randomDroppotion <= 6)
        {
            potiontext.text = "You got a " + potionlist[0].Itemname + " by " + name2;
           // if (Inventory_canvas.activeInHierarchy == true)
            { inventorygrids.AddItem(potionlist[0]); }
          //  else { GetFromMonster.AddItem2(potionlist[0]); }
            StartCoroutine(potiontextdisappear());
        }
        if (randomDroppotion >= 7 && randomDroppotion <= 10)
        {
            potiontext.text = "You got a " + potionlist[1].Itemname + " by " + name2;
          //  if (Inventory_canvas.activeInHierarchy == true)
            { inventorygrids.AddItem(potionlist[1]); }
          //  else { GetFromMonster.AddItem2(potionlist[1]); }
            StartCoroutine(potiontextdisappear());
        }

        if (mission == true)
        {
            if (player.scenewater_m4 == false && player.scenewater_m4_accept == true)
            {
                if (scenename == "scenewater" && missionnum == 4 && wm4.killcount<wm4.maxkillcount)
                {
                    randomDropmission = UnityEngine.Random.Range(1, 3);
                    if (randomDropmission == 2 && player.scenewater_m4 == false && player.scenewater_m4_accept == true)
                    {
                        missiontext.text = "You got a " + missionitem.Itemname + " by " + name2;
                        inventorygrids.AddItem(missionitem);
                        wm4a.add1();
                        StartCoroutine(missiontextdisappear());
                    }

                }
            }
            if (player.scenefire_m3 == false && player.scenefire_m3_accept == true )
            { if (scenename == "scenefire" && missionnum == 3 && fm3.killcount < fm3.maxkillcount)
                {   randomDropmission = UnityEngine.Random.Range(1, 3);
                     if (randomDropmission == 2 && player.scenefire_m3 == false && player.scenefire_m3_accept == true)
                        {
                            missiontext.text = "You got a " + missionitem.Itemname + " by " + name2;
                            inventorygrids.AddItem(missionitem);
                            fm3a.add1();
                            StartCoroutine(missiontextdisappear());
                        }
                    

                }
            }
            if (player.sceneearth_m2 == false && player.sceneearth_m2_accept == true )
            {
                if (scenename == "sceneearth" && missionnum == 2 && em2.killcount < em2.maxkillcount)
                {
                    randomDropmission = UnityEngine.Random.Range(1, 3);
                    if (randomDropmission == 2 && player.sceneearth_m2 == false && player.sceneearth_m2_accept == true)
                    {
                        missiontext.text = "You got a " + missionitem.Itemname + " by " + name2;
                        inventorygrids.AddItem(missionitem);
                        em2a.add1();
                        StartCoroutine(missiontextdisappear());
                    }

                }
            }
            if (player.sceneearth_m5 == false && player.sceneearth_m5_accept == true )
            {    if (scenename == "sceneearth" && missionnum == 5 && em5.killcount < em5.maxkillcount)
                {
                    randomDropmission = UnityEngine.Random.Range(1, 3);
                    if (randomDropmission == 2 && player.sceneearth_m5 == false && player.sceneearth_m5_accept == true)
                    {
                        missiontext.text = "You got a " + missionitem.Itemname + " by " + name2;
                        inventorygrids.AddItem(missionitem);
                        em5a.add1();
                        StartCoroutine(missiontextdisappear());
                    }
                }
            }
            if (player.sceneice_m4 == false && player.sceneice_m4_accept == true)
            {   if (scenename == "sceneice" && missionnum == 4 && im4.killcount < im4.maxkillcount)
                {
                    randomDropmission = UnityEngine.Random.Range(1, 3);
                    if (randomDropmission == 2 && player.sceneice_m4 == false && player.sceneice_m4_accept == true)
                    {
                        missiontext.text = "You got a " + missionitem.Itemname + " by " + name2;
                        inventorygrids.AddItem(missionitem);
                        im4a.add1();
                        StartCoroutine(missiontextdisappear());
                    }
                }

            }
        }

        randomDropequipment = UnityEngine.Random.Range(1, 101);
        if (randomDropequipment >= 11 && randomDropequipment <= 20)
        {
            equipmenttext.text = "You got a " + equipmentlist[0].Itemname + " by " + name2;
          //  if (Inventory_canvas.activeInHierarchy == true)
            { inventorygrids.AddItem(equipmentlist[0]); } //else { GetFromMonster.AddItem2(equipmentlist[0]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 31 && randomDropequipment <= 40)
        {
            equipmenttext.text = "You got a " + equipmentlist[1].Itemname + " by " + name2;
            //  if (Inventory_canvas.activeInHierarchy == true) 
            { inventorygrids.AddItem(equipmentlist[1]); } //else { GetFromMonster.AddItem2(equipmentlist[1]); }
            StartCoroutine(equipmenttextdisappear());
        }
        if (randomDropequipment >= 71 && randomDropequipment <= 80)
        {
            equipmenttext.text = "You got a " + equipmentlist[2].Itemname + " by " + name2;
            // if (Inventory_canvas.activeInHierarchy == true) 
            { inventorygrids.AddItem(equipmentlist[2]); } 
           //else { GetFromMonster.AddItem2(equipmentlist[2]); }
            StartCoroutine(equipmenttextdisappear());
        }


    }
    IEnumerator potiontextdisappear()
    {
        yield return new WaitForSeconds(2f);
        potiontext.text = "";
    }
    IEnumerator equipmenttextdisappear()
    {
        yield return new WaitForSeconds(2f);
        equipmenttext.text = "";
    }

    IEnumerator missiontextdisappear()
    {
        yield return new WaitForSeconds(2f);
        missiontext.text = "";
    }
}
