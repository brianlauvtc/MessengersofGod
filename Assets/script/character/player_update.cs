using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_update : MonoBehaviour
{
    public AudioSource upgradesound;
    public AudioSource deadsound;
    public GameObject[] hp_bar = new GameObject[30];
     bool t;
    Animator animator;
    player_move pm;
    public Text leveluptext;
   public  GameObject model, DeadCanvas, InventoryCanvas, CharacterInformationCanvas, ESCMenuCanvas, Canvas, SaveCanvas, SkillCanvas;
    // Start is called before the first frame update
    void Start()
    {   
        model = GameObject.FindGameObjectWithTag("Player");
        pm = model.GetComponent<player_move>();
        DeadCanvas = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().DeadCanvas;
        SkillCanvas = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().SkillCanvas;
        Canvas = GameObject.FindGameObjectWithTag("canvas");
        deadsound = model.GetComponent<AudioSource>();
        SaveCanvas = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().SaveCanvas;
        animator = model.GetComponent<Animator>();
        
       
        hp_bar = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().hp_bar;
        leveluptext = GameObject.FindGameObjectWithTag("enemycount").GetComponent<enemycount>().leveluptext;
        
        t = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        InventoryCanvas = pm.inventory;
        CharacterInformationCanvas = pm.information;
        ESCMenuCanvas = pm.ESCcanvas;


        if (player.exp >= player.main_max_exp)
        {
            player.skillpoint++;
            player.exp = player.exp - player.main_max_exp;
            player.level++; leveluptext.gameObject.SetActive(true); StartCoroutine(closetext());
            upgradesound.Play();
        }
        if (player.HealthPoint >= player.main_Max_HealthPoint)
        {
            player.HealthPoint = player.main_Max_HealthPoint;
        }
        if (player.ManaPoint >= player.main_Max_ManaPoint)
        {
            player.ManaPoint = player.main_Max_ManaPoint;

        }
        if (player.HealthPoint <= 0 )
        { player.HealthPoint = 0; }

            if (player.HealthPoint <= 0 && player.isdead == false)
        {
            deadsound.Play();
            player.isdead = true;
            player.HealthPoint = 0;
            player.dead = true;
            animator.SetBool("dead", true);
            animator.SetBool("walk", false);
            animator.SetBool("run", false);
            animator.SetBool("attack", false);
            animator.SetBool("skill1", false);
            animator.SetBool("skill2", false);
            animator.SetBool("skill3", false);
            animator.SetBool("skill4", false);
            hp_bar[0].gameObject.SetActive(false);
            hp_bar[1].gameObject.SetActive(false);
            hp_bar[2].gameObject.SetActive(false);
            hp_bar[3].gameObject.SetActive(false);
            hp_bar[4].gameObject.SetActive(false);
            hp_bar[5].gameObject.SetActive(false);
            hp_bar[6].gameObject.SetActive(false);
            hp_bar[7].gameObject.SetActive(false);
            hp_bar[8].gameObject.SetActive(false);
            hp_bar[9].gameObject.SetActive(false);
            hp_bar[10].gameObject.SetActive(false);
            hp_bar[11].gameObject.SetActive(false);
            hp_bar[12].gameObject.SetActive(false);
            hp_bar[13].gameObject.SetActive(false);
            hp_bar[14].gameObject.SetActive(false);
            hp_bar[15].gameObject.SetActive(false);
            hp_bar[16].gameObject.SetActive(false);
            hp_bar[17].gameObject.SetActive(false);
            hp_bar[18].gameObject.SetActive(false);
            hp_bar[19].gameObject.SetActive(false);
            hp_bar[20].gameObject.SetActive(false);
            hp_bar[21].gameObject.SetActive(false);
            hp_bar[22].gameObject.SetActive(false);
            hp_bar[23].gameObject.SetActive(false);
            hp_bar[24].gameObject.SetActive(false);
            hp_bar[25].gameObject.SetActive(false);
            hp_bar[26].gameObject.SetActive(false);
            hp_bar[27].gameObject.SetActive(false);
            hp_bar[28].gameObject.SetActive(false);
            hp_bar[29].gameObject.SetActive(false);

            InventoryCanvas.SetActive(false);
            CharacterInformationCanvas.SetActive(false);
            ESCMenuCanvas.SetActive(false);
            SkillCanvas.SetActive(false);
            StartCoroutine(disappear());
        }
        if (player.Defense > 1000)
        {
            player.main_Defense = 1000;
        }

    }
    IEnumerator disappear()
    {
        yield return new WaitForSeconds(3.85f);

        DeadCanvas.SetActive(true);
       

    }
    IEnumerator closetext()
    {
        yield return new WaitForSeconds(3f);
        leveluptext.gameObject.SetActive(false);
    }
}


