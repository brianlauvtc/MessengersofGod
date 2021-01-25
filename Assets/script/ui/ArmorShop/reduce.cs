using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class reduce : MonoBehaviour
{
    public AudioSource clicksound;
    public InputField inputfield;
    buyamount s;
    // Start is called before the first frame update
    void Start()
    {
        s = inputfield.GetComponent<buyamount>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void minus2() { s.minus(); clicksound.Play(); StartCoroutine(equipment()); }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        clicksound.Stop();
    }
}
