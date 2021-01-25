using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class add2 : MonoBehaviour
{
    public AudioSource clicksound;
    public InputField inputfield;
    buyamount2 s;
    // Start is called before the first frame update
    void Start()
    {
        s = inputfield.GetComponent<buyamount2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void plus2() { s.plus(); clicksound.Play(); StartCoroutine(equipment()); }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        clicksound.Stop();
    }
}
