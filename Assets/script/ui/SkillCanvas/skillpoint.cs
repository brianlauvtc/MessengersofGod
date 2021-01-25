using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skillpoint : MonoBehaviour
{
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (player.skillpoint <= 1)
        { t.text = "You have "  + player.skillpoint + " skill point."; }
        else { t.text = "You have" + player.skillpoint + " skill points."; };
    }
}
