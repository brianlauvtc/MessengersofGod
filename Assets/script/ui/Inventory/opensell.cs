using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class opensell : MonoBehaviour
{
    public AudioSource clicksound;

    public GameObject sell;
    public InputField inputfield;
    InventorySelect Is;
    public Inventory inventorygrid;
    public GameObject cannotsellCanvas;
    public GameObject inventoryobject;
    sell s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Is = inventoryobject.GetComponent<InventorySelect>();
       
        s = inputfield.GetComponent<sell>();

    }
    public void open()
    {
        if (Is.selectnum != 22 && inventorygrid.items[Is.selectnum].Type != type.crystal && inventorygrid.items[Is.selectnum].Type != type.missionobject)
        {
            clicksound.Play(); StartCoroutine(equipment());
            s.num = 1;
            sell.SetActive(true);
        }
        if (inventorygrid.items[Is.selectnum].Type == type.crystal || inventorygrid.items[Is.selectnum].Type == type.missionobject)
        {
            cannotsellCanvas.SetActive(true);
        }

    }
    public void cencel()
    {
        clicksound.Play(); StartCoroutine(equipment());
        sell.SetActive(false);
    }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        clicksound.Stop();
    }
}
