using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour {

    public Text text_name;
    public changeScene cs;
    public Text please;
    public void NextScene (string sceneName) {
        if (text_name.text == "")
        {
            please.gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                static_hkl_inventory.item[i] =null;
                static_hkl_inventory.num[i] =0;
            }
            for (int i = 0; i < 21; i++)
            {
                static_hkl_inventory.items[i] = null;
                static_hkl_inventory.itemCount[i] = 0;
            }
            cs.startGame(sceneName);
            }
      
    }
    public void setname()
    {
        player.player_name = text_name.text;
    }
}


