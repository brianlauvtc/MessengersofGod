using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaudio_hotkey : MonoBehaviour
{
    public AudioSource hpsound, mpsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator hp()
    {
        yield return new WaitForSeconds(1f);
        hpsound.Stop();
    }
   public IEnumerator mp()
    {
        yield return new WaitForSeconds(1f);
        mpsound.Stop();
    }
}
