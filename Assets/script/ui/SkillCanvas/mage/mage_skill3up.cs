using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mage_skill3up : MonoBehaviour
{
    public Text moneytext;
    public GameObject player2;
    public Mage_skill_3 player_skill_3;
    public AudioSource upgradesound;
    public int basicmoney, mainmoney, growmoney;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 3)
        {
            moneytext.text = "Need money : " + mainmoney.ToString();
            player2 = GameObject.FindGameObjectWithTag("Player");
            player_skill_3 = player2.GetComponent<Mage_skill_3>();
            mainmoney = basicmoney + (player_skill_3.skill_level - 1) * growmoney;
        }
    }
    public void upgrade()
    {
        if (player.money >= mainmoney && player.skillpoint > 0)
        {
            player.money -= mainmoney;
            upgradesound.Play();
            player_skill_3.skill_level++;
            player.skillpoint--;

        }
    }
}
