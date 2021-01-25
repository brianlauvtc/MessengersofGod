using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closebutton : MonoBehaviour
{
    public GameObject close;
    public AudioSource backgroundsound;
    public AudioSource bosssound;
    public AudioSource talksound;
    public float bossvolum;
    public float bgvolum;
    public bool move;
    public NPC_move npcmove;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            closeclose();

        }
    }
    public void closeclose()
    {
        close.SetActive(false);
        backgroundsound.volume = bgvolum;
        bosssound.volume = bossvolum;
        talksound.Stop();
        if (move == true)
        {
            npcmove.talk = false;
            animator.SetBool("talk", false);
            animator.SetBool("walk", false);
        }
        }
}
