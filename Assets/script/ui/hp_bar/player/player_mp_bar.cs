using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mp_bar : MonoBehaviour
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
        this.transform.localPosition = new Vector3((-pos + pos * (player.ManaPoint / player.main_Max_ManaPoint)), 0, 0);

    }
}
