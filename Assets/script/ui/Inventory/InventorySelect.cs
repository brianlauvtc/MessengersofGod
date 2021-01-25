using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventorySelect : MonoBehaviour
{
     Image[] itemImages = new Image[21];
    public Image selectedimage;
   public int selectnum;
    public Image[] imagebg = new Image[21];
    public GameObject grids;
   

    // Start is called before the first frame update
    void Start()
    {
        itemImages = grids.GetComponent<Inventory>().itemImages;
    }

    // Update is called once per frame
    void Update()
    {   if (selectedimage == null)
        {
            selectnum = 22;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            selectedimage = null;
        }

        for (int i = 0; i < 21; i++)
        {
            if (i == selectnum)
            {
                imagebg[i].gameObject.SetActive(true);
                
            }else { imagebg[i].gameObject.SetActive(false); }
        }
    }
    public void setnum(int i)
    {
        selectedimage = itemImages[i];
        selectnum = i;
      
    }
}
