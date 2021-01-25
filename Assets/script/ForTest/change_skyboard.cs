using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_skyboard : MonoBehaviour
{
    public  Material skybox;
    public Material old_skybox;
    public Material normal_skybox;
    public GameObject cam1;
    public GameObject cam2;
   
    // Start is called before the first frame update
    void Start()
    {
        old_skybox = RenderSettings.skybox;
    }

    // Update is called once per frame
    void Update()
    {   
    }
    public void change_sky()
    {
        RenderSettings.skybox = skybox;
    }
    public void change_old_sky()
    {
        RenderSettings.skybox = old_skybox;
    }

    public void change_normal_sky()
    {
        RenderSettings.skybox = normal_skybox;
    }
    public void change()
    {
      
        cam1.SetActive(false);
        cam2.SetActive(true);
    }

  
}
