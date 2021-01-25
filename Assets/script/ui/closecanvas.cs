using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closecanvas : MonoBehaviour
{
    public GameObject[] canvas;
    public InventorySelect Is;
    public armorselect As;

    public AudioSource backgroundsound;
    public AudioSource bosssound;
    public AudioSource talksound;
    public float bossvolum;
    public float bgvolum;
    public bool move;
    public NPC_move npcmove1;
    public Animator animator1;
    public NPC_move npcmove2;
    public Animator animator2;
    public bool npc3;
    public NPC_move npcmove3;
    public Animator animator3;
    public GameObject Detail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //    if (canvas[1].activeInHierarchy == false)
       // { Is.selectedimage = null; }
       // if (canvas[0].activeInHierarchy == false)
      //  { As.selectedimage = null; }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Detail.SetActive(false);
            for (int i = 0; i < canvas.Length; i++)
            {
                canvas[i].SetActive(false);
            }
            backgroundsound.volume = bgvolum;
            bosssound.volume = bossvolum;
            talksound.Stop();
            if (move == true)
            {
                npcmove1.talk = false;
                animator1.SetBool("talk", false);
                npcmove2.talk = false;
                animator2.SetBool("talk", false);
                if (npc3 == true)
                {
                    npcmove3.talk = false;
                    animator3.SetBool("talk", false);
                }
            }
        }   
    }
}
