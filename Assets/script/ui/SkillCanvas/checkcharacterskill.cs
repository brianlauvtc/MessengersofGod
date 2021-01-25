using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkcharacterskill : MonoBehaviour
{
    public GameObject warriorskillimage;
    public GameObject mageskillimage;
    public GameObject gunmanskillimage;
    public GameObject shooterskillimage;

    public GameObject warriorskilldetail;
    public GameObject mageskilldetail;
    public GameObject gunmanskilldetail;
    public GameObject shooterskilldetail;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 1)
        {
            warriorskillimage.SetActive(false);
            warriorskilldetail.SetActive(false);
            mageskilldetail.SetActive(false);
            mageskillimage.SetActive(false);
            gunmanskillimage.SetActive(false);
            gunmanskilldetail.SetActive(false);
            shooterskilldetail.SetActive(true);
            shooterskillimage.SetActive(true);
        }
        if (player.job_num == 2)
        {
            warriorskillimage.SetActive(true);
            warriorskilldetail.SetActive(true);
            mageskilldetail.SetActive(false);
            mageskillimage.SetActive(false);
            gunmanskillimage.SetActive(false);
            gunmanskilldetail.SetActive(false);
            shooterskilldetail.SetActive(false);
            shooterskillimage.SetActive(false);
        }
        if (player.job_num == 3)
        {
            warriorskillimage.SetActive(false);
            warriorskilldetail.SetActive(false);
            mageskilldetail.SetActive(true);
            mageskillimage.SetActive(true);
            gunmanskillimage.SetActive(false);
            gunmanskilldetail.SetActive(false);
            shooterskilldetail.SetActive(false);
            shooterskillimage.SetActive(false);
        }
        if (player.job_num == 4)
        {
            warriorskillimage.SetActive(false);
            warriorskilldetail.SetActive(false);
            mageskilldetail.SetActive(false);
            mageskillimage.SetActive(false);
            gunmanskillimage.SetActive(true);
            gunmanskilldetail.SetActive(true);
            shooterskilldetail.SetActive(false);
            shooterskillimage.SetActive(false);
        }
    }
}
