using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class crystal_bar : MonoBehaviour
{
    public RectTransform rt;
    float pos;
    public Text hptext;
    public crystal_Character_Attribute mca;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = rt.sizeDelta.x;
        this.transform.localPosition = new Vector3((-pos + pos * (mca.HealthPoint / mca.Max_HealthPoint)), 0, 0);
        hptext.text = mca.HealthPoint.ToString() + " / " + mca.Max_HealthPoint.ToString();
    }
}
