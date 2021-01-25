using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class plus : MonoBehaviour
{
    public AudioSource clicksound;
    public InputField inputfield;
    sell s;
    // Start is called before the first frame update
    void Start()
    {
        s = inputfield.GetComponent<sell>();
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
