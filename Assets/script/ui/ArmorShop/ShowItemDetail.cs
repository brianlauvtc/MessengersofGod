using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowItemDetail : MonoBehaviour
{
    public armorshopselect ass;
    public Text ItemName;
    public Image ItemImage;
    public Text HPamount;
    public Text Defenceamount;
    public GameObject pricetext;
    public GameObject needPrice;
    public Text pricenum;
    public Text attackamont;
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
            HPamount.text = "";
            Defenceamount.text = "";
            attackamont.text = "";
            pricetext.SetActive(false);
            needPrice.SetActive(false);
            buybutton.SetActive(false);
        } else {

            ItemImage.GetComponent<Image>().enabled = true;
            ItemImage.GetComponent<Image>().sprite = ass.SelectedItem.sprite;
            ItemName.text = ass.SelectedItem.Itemname;
            if (ass.SelectedItem.Type == type.equipment)
            {
                HPamount.text = "Bonus HP : " + ass.SelectedItem.hp_bonus.ToString();
                Defenceamount.text = "Bonus Defence : " + ass.SelectedItem.Defense_bonus.ToString();
                attackamont.text = "";
            }        
            pricenum.text = ass.SelectedItem.buyprice.ToString();
            if (ass.SelectedItem.Type == type.weapon)
            { attackamont.text = "Bonus Damage : " + ass.SelectedItem.damage_bonus.ToString(); Defenceamount.text = ""; HPamount.text = ""; }
            pricetext.SetActive(true);
            needPrice.SetActive(true);
            buybutton.SetActive(true);
        }


    }
}
