using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.sceneice_m6 == true)
        {
            NextScene("EndStoryScene");
        }
    }

    public void NextScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
