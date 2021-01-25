using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openinformation : MonoBehaviour
{
    public closeSound Sound;
    public AudioSource closesound, opensound;
    public GameObject information;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
           
            if (information.activeInHierarchy == true)
            {
                Sound.playsound(closesound);
                information.SetActive(false);
            }
            else {  information.SetActive(true); opensound.Play(); StartCoroutine(weapon()); }
        }
    }

    public void close() { Sound.playsound(closesound); information.SetActive(false);  }
   

    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        opensound.Stop();
    }
}
