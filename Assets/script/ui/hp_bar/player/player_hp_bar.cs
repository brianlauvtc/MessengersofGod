using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_hp_bar : MonoBehaviour
{
    public RectTransform rt;
    float pos;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = rt.sizeDelta.x;

        if (player.count >= 5)
        {
            player.nom_fighting_status = true;
            player.fighting_status = false;
        }

        this.transform.localPosition = new Vector3((-pos + pos * (player.HealthPoint / player.main_Max_HealthPoint)), 0, 0);
    }
}
