using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class changeScene : MonoBehaviour
{
    public string sceneName;
    levelLoader Loader;
    public Text please;
    public Text text_name;
    public GameObject intro;
    // Start is called before the first frame update
    void Start()
    {
        try{
        Loader = GameObject.Find("LevelLoader").GetComponent<levelLoader>();
        }
        catch(System.Exception e){
            Debug.Log(e.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame(string sceneName) {
        if (text_name.text == "")
        {
            please.gameObject.SetActive(true);
        }
         else if (Loader == null)
        {
            intro.SetActive(false);
            for (int i = 0; i < 5; i++)
            {
                static_hkl_inventory.item[i] = null;
                static_hkl_inventory.num[i] = 0;
            }
            for (int i = 0; i < 21; i++)
            {
                static_hkl_inventory.items[i] = null;
                static_hkl_inventory.itemCount[i] = 0;
            }
            SceneManager.LoadScene(sceneName); }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                static_hkl_inventory.item[i] = null;
                static_hkl_inventory.num[i] = 0;
            }
            for (int i = 0; i < 21; i++)
            {
                static_hkl_inventory.items[i] = null;
                static_hkl_inventory.itemCount[i] = 0;
            }
            Loader.LoadLevel(sceneName); }
    }
}
