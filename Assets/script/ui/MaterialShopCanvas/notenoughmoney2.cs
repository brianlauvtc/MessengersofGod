using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notenoughmoney2 : MonoBehaviour
{
    public GameObject buybutton;
    public materialshopselect ass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ass.SelectedID != 12)
        {
            if (player.money < ass.SelectedItem.buyprice)
            {
                buybutton.SetActive(false);
            }
            else { buybutton.SetActive(true); }
        }
    }
}
