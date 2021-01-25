using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openskill : MonoBehaviour
{
    public closeSound Sound;
    public AudioSource closesound, opensound;
    public GameObject skillcanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
          
            if (skillcanvas.activeInHierarchy == false)
            {
                opensound.Play(); StartCoroutine(weapon());
                skillcanvas.SetActive(true);
            }
            else { Sound.playsound(closesound); skillcanvas.SetActive(false);  }
        }
    }
    public void close() {
         Sound.playsound(closesound);
        skillcanvas.SetActive(false);
    }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        closesound.Stop();
    }
    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        opensound.Stop();
    }
}
