using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class boss_bar : MonoBehaviour
{
    public Text hptext;
    public Monster_Character_Attribute mca;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localPosition = new Vector3((-301 + 301 * (mca.HealthPoint / mca.Max_HealthPoint)), 0, 0);
        hptext.text = mca.HealthPoint.ToString() + " / " + mca.Max_HealthPoint.ToString();
    }
}
