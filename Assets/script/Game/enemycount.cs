using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemycount : MonoBehaviour
{
    public Text killtext;
    public GameObject Crystal;
    public GameObject[] hp_bar;
    public GameObject[] enemy;
    public monster_spawner[] spawnpoint;
    public Text skiltext;
    public Text manatext;
    public int cd_count;
    public int manacd_count;
    public int close_count;
    public int target_count;
    public Image[] Panel;
    public Text leveluptext;
    public Text notargettext;
    public Text notclosetext;

    public GameObject InventoryCanvas, CharacterInformationCanvas, ESCMenuCanvas, SaveCanvas, DeadCanvas, SkillCanvas;
    // Start is called before the first frame update
    public void cold_cown()
    {
        if (cd_count > 0)
        {
            cd_count--;
        }
    }

    public void manacold_cown()
    {
        if (manacd_count > 0)
        {
            manacd_count--;
        }
    }

    public void target_count_cown()
    {
        if (target_count > 0)
        {
            target_count--;
        }
    }
    public void close_count_cown()
    {
        if (close_count > 0)
        {
            close_count--;
        }
    }
    void Start()
    {
        cd_count = 0;
        InvokeRepeating("cold_cown", 1, 1);
        InvokeRepeating("manacold_cown", 1, 1);
        InvokeRepeating("target_count_cown", 1, 1);
        InvokeRepeating("close_count_cown", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (manacd_count == 0)
        {
            manatext.text = "";
        }
        if (cd_count == 0)
        {
            skiltext.text = "";
        }
        if (close_count == 0)
        {
            notclosetext.text = "";
        }
        if (target_count == 0)
        {
            notargettext.text = "";
        }
    }

}
