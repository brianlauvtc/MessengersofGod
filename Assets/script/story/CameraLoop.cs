using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLoop : MonoBehaviour
{
    public float time;
    public int num;
    public GameObject[] loop = new GameObject[8];
    public int count;
    public bool cam3;
    public GameObject[] boss = new GameObject[4];
    public GameObject[] crystal = new GameObject[4];
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        InvokeRepeating("looping", time, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void looping()
    {
        if (count <= num-2)
        {
            loop[count].SetActive(false);
            if (cam3 == true && count == 3)
            {
                crystal[0].SetActive(false);
                boss[0].SetActive(true);
                crystal[1].SetActive(false);
                crystal[2].SetActive(false);
                crystal[3].SetActive(false);               
                boss[1].SetActive(true);
                boss[2].SetActive(true);
                boss[3].SetActive(true);
            }
            loop[count+1].SetActive(true);
            count++;
        }
    }

}
