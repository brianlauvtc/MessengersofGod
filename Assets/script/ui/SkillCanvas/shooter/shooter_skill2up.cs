using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class shooter_skill2up : MonoBehaviour
{
    public AudioSource upgradesound;
    public Text moneytext;
    public GameObject player2;
    public Shooter_skill_2 player_skill_2;
    public int basicmoney, mainmoney, growmoney;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 1)
        {
            moneytext.text = "Need money : " + mainmoney.ToString();
            player2 = GameObject.FindGameObjectWithTag("Player");
            player_skill_2 = player2.GetComponent<Shooter_skill_2>();
            mainmoney = basicmoney + (player_skill_2.skill_level - 1) * growmoney;
        }
    }
    public void upgrade()
    {
        if (player.money >= mainmoney && player.skillpoint > 0)
        {
            player.money -= mainmoney;
            upgradesound.Play();
            player_skill_2.skill_level++;
            player.skillpoint--;

        }
    }
}
