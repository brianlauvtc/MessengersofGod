using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playerdata : MonoBehaviour
{
    public Text playernameslot;
    public Text playerlevelslot;
    public Text playerexpslot;
    public Text playerhpslot;
    public Text playermpslot;
    public Text playerdefenceslot;
    public Text playerdamageslot;





    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        if (player.player_name != "")
        { playernameslot.text = player.player_name; }
        else { playernameslot.text = " no name"; }
        playerlevelslot.text = player.level.ToString();
        playerexpslot.text = player.exp.ToString() + " / " + player.main_max_exp.ToString();
        playerhpslot.text = player.HealthPoint.ToString() + " / " + player.main_Max_HealthPoint.ToString();
        playermpslot.text = player.ManaPoint.ToString() + " / " + player.main_Max_ManaPoint.ToString();
        playerdefenceslot.text = player.main_Defense.ToString();
        playerdamageslot.text = player.main_attack_damage.ToString();
    }
}
