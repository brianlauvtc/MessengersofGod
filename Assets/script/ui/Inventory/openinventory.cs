using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class openinventory : MonoBehaviour
{
    public closeSound Sound;
    public AudioSource closesound, opensound;
    public GameObject inventory;
    public GameObject grid;
    public Inventory inventorygrid;
    public GameObject Detail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.scene_name = SceneManager.GetActiveScene().name.ToString();
        

            if (Input.GetKeyDown(KeyCode.B))
        {
           
            if (inventory.activeInHierarchy == true)
            {
                Sound.playsound(closesound); 
                grid.GetComponent<InventorySelect>().selectedimage = null;
                Detail.SetActive(false);
                inventory.SetActive(false); 
            }
            else
            {
                inventory.SetActive(true);
                opensound.Play();
                StartCoroutine(weapon());

                for (int i = 0; i < 21; i++)
                {
                    if (GetFromMonster.items[i] != null)
                    {   for (int k = 0; k < GetFromMonster.itemCount[k]; i++)
                        { inventorygrid.AddItem(GetFromMonster.items[i]); }
                        GetFromMonster.items[i] = null;
                        GetFromMonster.itemCount[i] = 0;
                    }
                }
             
            }
        }

    }
    public void close() { Sound.playsound(closesound); Detail.SetActive(false); inventory.SetActive(false);  }
    
    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        opensound.Stop();
    }
}
