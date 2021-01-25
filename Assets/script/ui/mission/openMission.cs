using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openMission : MonoBehaviour
{
    public closeSound Sound;
    public AudioSource closesound, opensound;
    public GameObject mission;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {

            if (mission.activeInHierarchy == true)
            {
                Sound.playsound(closesound);
                mission.SetActive(false);
            }
            else { mission.SetActive(true); opensound.Play(); StartCoroutine(weapon()); }
        }
    }

    public void close() { Sound.playsound(closesound); mission.SetActive(false);  }
   

    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        opensound.Stop();
    }
}
