using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class stoptime : MonoBehaviour
{
    public GameObject menu;
    public GameObject save;
    public GameObject esc;
    public GameObject asksave;
    public GameObject inventory;
    public GameObject person;
    public GameObject main;
    public GameObject skill;
    public GameObject armorshop;
    public GameObject materialshop;
    public GameObject detail;
  
    public closecanvas cc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (menu.activeInHierarchy == true )
        { Time.timeScale = 0; main.SetActive(false); }
        else { Time.timeScale = 1; main.SetActive(true); }

        if (menu.activeInHierarchy == true)
        {
            detail.SetActive(false);
            for (int i = 0; i < cc.canvas.Length; i++)
            {if (cc.canvas[i].name != "ESCMenuCanvas" )
                { cc.canvas[i].SetActive(false); }
            }
        }


            if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (menu.activeInHierarchy == true )
            {
                detail.SetActive(false);
                for (int i = 0; i < cc.canvas.Length; i++)
                {
                    cc.canvas[i].SetActive(false);
                }
                menu.SetActive(false);

                save.SetActive(false);
                if (esc.gameObject.activeInHierarchy == false)
                { esc.SetActive(true); }
                if (asksave.gameObject.activeInHierarchy == true)
                { asksave.SetActive(false); }
            }
           

        }

        
    }
}
