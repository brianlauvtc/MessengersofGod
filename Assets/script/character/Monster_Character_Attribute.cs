using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster_Character_Attribute : MonoBehaviour {
    public float HealthPoint;
    public float Max_HealthPoint;
    public float Defense;
    public float attack_damage;
    public int deadmoney, deadexp;
    public monster_spawner ms;
   

   
    
    // Use this for initialization
    void Start () {

      
        


    }
	
	
	void Update () {
    

        if (HealthPoint > Max_HealthPoint)
        {
            HealthPoint = Max_HealthPoint;
        }
        if (HealthPoint < 0)
        {
            HealthPoint = 0;
        }
        

        if (Defense > 1000) 
        {
            Defense = 1000;
        }

       
	}

    public void get_damage(int damage)
    {
           ms.getdamage = true;
           HealthPoint -= Mathf.Round(damage * (1 - Defense / 1000));
            print("get = " +damage);
    }
  
}
