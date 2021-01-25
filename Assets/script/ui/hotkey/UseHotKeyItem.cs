using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseHotKeyItem : MonoBehaviour
{
    public playaudio_hotkey audiohotkey;
    public hotkeylist hkl;
    public int numhk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) && !(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && !(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
        { if (numhk == 0) { useitem(0); } }
        if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) && !(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && !(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
        { if (numhk == 1) { useitem(1); } }
        if ((Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) && !(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && !(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
        { if (numhk == 2) {useitem(2); }}
        if ((Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) && !(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && !(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
        { if (numhk == 3) {useitem(3); }}
        if ((Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5)) && !(Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && !(Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)))
        { if (numhk == 4) {useitem(4); }}

    }
    public void useitem(int a)
    { if (hkl.item[a] != null)
        { 
            if (hkl.num[a] == 0)
            {
                hkl.item[a] = null;
            }
            if (hkl.item[a].Type == type.prop)
            {
                if (hkl.item[a].Restoretype == restoretype.hp)
                {
                    if ((player.main_Max_HealthPoint - player.HealthPoint) >= hkl.item[a].restore)
                    {
                        hkl.num[a]--;
                        audiohotkey.hpsound.Play();
                        StartCoroutine(audiohotkey.hp());
                        player.HealthPoint += hkl.item[a].restore;
                    }
                }
                if (hkl.item[a].Restoretype == restoretype.mp)
                {
                    if ((player.main_Max_ManaPoint - player.ManaPoint) >= hkl.item[a].restore)
                    {
                        hkl.num[a]--;
                        audiohotkey.mpsound.Play();
                        StartCoroutine(audiohotkey.mp());
                        player.ManaPoint += hkl.item[a].restore;
                    }
                }


            }
        }
    }
}