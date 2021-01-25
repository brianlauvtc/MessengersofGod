using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void NextScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
