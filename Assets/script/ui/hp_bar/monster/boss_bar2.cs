using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class boss_bar2 : MonoBehaviour
{
    public RectTransform rt;
    float pos;
    public Text hptext;
    public Monster_Character_Attribute mca;
    public monster_num mm;
    public enemycount ec;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = rt.sizeDelta.x;
        ec = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>();
        mm = ec.hp_bar[mm.getnum()].gameObject.GetComponent<monster_num>();
        mca = ec.enemy[mm.getnum()].gameObject.GetComponent<Monster_Character_Attribute>();
        this.transform.localPosition = new Vector3((-pos + pos * (mca.HealthPoint / mca.Max_HealthPoint)), 0, 0);
        hptext.text = mca.HealthPoint.ToString() + " / " + mca.Max_HealthPoint.ToString();
    }
}
