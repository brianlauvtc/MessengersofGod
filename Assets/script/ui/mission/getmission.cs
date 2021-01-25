using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getmission : MonoBehaviour
{
    public GameObject mission_object;
    public GameObject askopen;
    public bool mission1;
    public string scenename;
    public fire_mission1 fm1;
    public earth_mission1 em1;
    public water_mission1 wm1;
    public ice_mission1 im1;
    public GameObject question;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openmission()
    {
        mission_object.SetActive(true);
        askopen.SetActive(false);
        if (mission1 == true)
        {
            if (scenename.Equals("scenefire") && player.scenefire_m1_finish == false)
            {
                player.scenefire_m1_finish = true;
                fm1.finish = true;
                question.SetActive(true);
            }
            if (scenename.Equals("scenewater") && player.scenewater_m1_finish == false)
            {
                player.scenewater_m1_finish = true;
                wm1.finish = true;
                question.SetActive(true);
            }
            if (scenename.Equals("sceneearth") && player.sceneearth_m1_finish == false)
            {
                player.sceneearth_m1_finish = true;
                em1.finish = true;
                question.SetActive(true);
            }
            if (scenename.Equals("sceneice") && player.sceneice_m1_finish == false)
            {
                player.sceneice_m1_finish = true;
                im1.finish = true;
                question.SetActive(true);
            }
        }
    }
}
