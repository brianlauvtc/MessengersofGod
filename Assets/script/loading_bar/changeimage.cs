using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class changeimage : MonoBehaviour
{
    public bool fireallow;
    public Sprite fireimage;

    public bool waterallow;
    public Sprite waterimage;

    public bool earthallow;
    public Sprite earthimage;

    public bool iceallow;
    public Sprite iceimage;

    public string scenename;
    public Image i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scenename == "scenefire" && fireallow == true && fireimage != null)
        { i.sprite = fireimage; }
        if (scenename == "scenewater" && waterallow == true && waterimage != null)
        { i.sprite = waterimage; }
        if (scenename == "sceneearth" && earthallow == true && earthimage != null)
        { i.sprite = earthimage; }
        if (scenename == "sceneice" && iceallow == true && iceimage != null)
        { i.sprite = iceimage; }
    }
}
