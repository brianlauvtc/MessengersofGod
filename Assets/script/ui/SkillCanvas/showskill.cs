using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showskill : MonoBehaviour
{
    public GameObject skill1;
    public GameObject skill2;
    public GameObject skill3;
    public GameObject skill4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void openskill1()
    {
   
        skill1.gameObject.SetActive(true);
        skill2.gameObject.SetActive(false);
        skill3.gameObject.SetActive(false);
        skill4.gameObject.SetActive(false);
      
    }
    public void openskill2()
    {
        skill1.gameObject.SetActive(false);
        skill2.gameObject.SetActive(true);
        skill3.gameObject.SetActive(false);
        skill4.gameObject.SetActive(false);

    }
    public void openskill3()
    {
        skill1.gameObject.SetActive(false);
        skill2.gameObject.SetActive(false);
        skill3.gameObject.SetActive(true);
        skill4.gameObject.SetActive(false);
        
    }
    public void openskill4()
    {
        skill1.gameObject.SetActive(false);
        skill2.gameObject.SetActive(false);
        skill3.gameObject.SetActive(false);
      
        skill4.gameObject.SetActive(true);
    }
   
}
