using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunner_skill1up : MonoBehaviour
{
    public AudioSource upgradesound;
    public Text moneytext;
    public GameObject player2;
    public gunner_skill_1 player_skill_1;
    public int basicmoney, mainmoney, growmoney;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 4)
        {
            moneytext.text = "Need money : " + mainmoney.ToString();
            player2 = GameObject.FindGameObjectWithTag("Player");
            player_skill_1 = player2.GetComponent<gunner_skill_1>();
            mainmoney = basicmoney + (player_skill_1.skill_level - 1) * growmoney;
        }
    }
    public void upgrade()
    {
        if (player.money >= mainmoney && player.skillpoint>0)
        {
            upgradesound.Play();
            player.money -= mainmoney;
            player_skill_1.skill_level++;
            player.skillpoint--;

        }
    }
}
