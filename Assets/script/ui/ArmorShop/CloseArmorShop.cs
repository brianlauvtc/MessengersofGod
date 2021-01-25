using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CloseArmorShop : MonoBehaviour
{
    public AudioSource closesound;
    public closeSound Sound;
    public armorshopselect ass;
    public GameObject canvas;
    public InputField num;
    public buyamount bm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {if (canvas.activeInHierarchy == true)
            {
                num.text = "1";
                bm.num = 0;
                ass.SelectedItem = null;
                Sound.playsound(closesound);
                canvas.SetActive(false);
                
            } 
        }
    }
    public void close()
    {
        num.text = "0";
        bm.num = 0;
        ass.SelectedItem = null;
        Sound.playsound(closesound);
        canvas.SetActive(false);
        
       
    }
   

   
}
