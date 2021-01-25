using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeSound : MonoBehaviour
{
    public AudioSource closesound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playsound(AudioSource closesound2)
    {
        closesound = closesound2;
        closesound.Play();
        StartCoroutine(equipment());
    }


    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        closesound.Stop();
    }
}
