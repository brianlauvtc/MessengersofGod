using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowItemDetail2 : MonoBehaviour
{
    public materialshopselect ass;
    public Text ItemName;
    public Image ItemImage;

    public Text Description;
    public GameObject pricetext;
    public GameObject needPrice;
    public Text pricenum;
   
    public GameObject buybutton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (ass.SelectedItem == null)
        {
            ItemImage.GetComponent<Image>().sprite = null;
            ItemImage.GetComponent<Image>().enabled = false;
            ItemName.text = "";
            Description.text = "";
           
            pricetext.SetActive(false);
            needPrice.SetActive(false);
            buybutton.SetActive(false);
        } else {

            ItemImage.GetComponent<Image>().enabled = true;
            ItemImage.GetComponent<Image>().sprite = ass.SelectedItem.sprite;
            ItemName.text = ass.SelectedItem.Itemname;
            if (ass.SelectedItem.Type == type.prop)
            {
                Description.text = ass.SelectedItem.introduction;
              
            }
            pricetext.SetActive(true);
            pricenum.text = ass.SelectedItem.buyprice.ToString();
        
           
            needPrice.SetActive(true);
            buybutton.SetActive(true);
        }


    }
}
