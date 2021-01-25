 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savefilename : MonoBehaviour
{

    [SerializeField]
    private string fileName = "Profile.bin"; // file to save with the specified resolution
    [SerializeField]
    private bool dontDestroyOnLoad; // the object will move from one scene to another (you only need to add it once)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        SaveSystem.Initialize(fileName);
        if (dontDestroyOnLoad) DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    
   
}
