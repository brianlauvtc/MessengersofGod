using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSkillImage : MonoBehaviour
{ public Image[] skillimage = new Image[4];
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.job_num == 1)
        {
            skillimage[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Shooter/skill1");
            skillimage[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Shooter/skill2");
            skillimage[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Shooter/skill3");
            skillimage[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Shooter/skill4");
        }
        if (player.job_num == 2)
        {
            skillimage[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/warrior/skill1");
            skillimage[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/warrior/skill2");
            skillimage[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/warrior/skill3");
            skillimage[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/warrior/skill4");
        }
        if (player.job_num == 3)
        {
            skillimage[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Mage/skill1");
            skillimage[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Mage/skill2");
            skillimage[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Mage/skill3");
            skillimage[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Mage/skill4");
        }
        if (player.job_num == 4)
        {
            skillimage[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Gunman/skill1");
            skillimage[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Gunman/skill2");
            skillimage[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Gunman/skill3");
            skillimage[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("Image/Gunman/skill4");
        }
    }
}
