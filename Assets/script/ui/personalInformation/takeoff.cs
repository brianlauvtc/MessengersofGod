using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class takeoff : MonoBehaviour
{
    public AudioSource clicksound;
    public GameObject inventoryobject, personalarmor;
    public Image[] itemImages = new Image[6];
   public  armorselect ast;
    personalarmor Ppersonalarmor;
    Inventory inventory;
    public Button b;
    public AudioSource equipmentsound, weaponsound;
    // Start is called before the first frame update
    void Start()
    {
        Ppersonalarmor = personalarmor.GetComponent<personalarmor>();
        inventory = inventoryobject.GetComponent<Inventory>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void take_off()
    {
        clicksound.Play();
        inventory.AddItem(ast.selectedimage);
        itemImages[ast.armorname].sprite = null;
        if (ast.armorname == 0) { Ppersonalarmor.headslot = null; Ppersonalarmor.headpicture.name = "headImage"; Ppersonalarmor.headpicture.enabled = false; equipmentsound.Play();StartCoroutine(equipment());  }
        if (ast.armorname == 1) { Ppersonalarmor.glovesslot = null; Ppersonalarmor.glovespicture.name = "glovesImage"; Ppersonalarmor.glovespicture.enabled = false; equipmentsound.Play(); StartCoroutine(equipment()); }
        if (ast.armorname == 2) { Ppersonalarmor.clothesslot = null; Ppersonalarmor.clothespicture.name = "clothesImage"; Ppersonalarmor.clothespicture.enabled = false; equipmentsound.Play(); StartCoroutine(equipment()); }
        if (ast.armorname == 3) { Ppersonalarmor.weaponslot = null; Ppersonalarmor.weaponpicture.name = "weaponImage"; Ppersonalarmor.weaponpicture.enabled = false; weaponsound.Play(); StartCoroutine(weapon()); }
        if (ast.armorname == 4) { Ppersonalarmor.trouserslot = null; Ppersonalarmor.trouserpicture.name = "trouserImage"; Ppersonalarmor.trouserpicture.enabled = false; equipmentsound.Play(); StartCoroutine(equipment()); }
        if (ast.armorname == 5) { Ppersonalarmor.shoeslot = null; Ppersonalarmor.shoepicture.name = "shoeImage"; Ppersonalarmor.shoepicture.enabled = false; equipmentsound.Play(); StartCoroutine(equipment()); }
       ast.selectedimage = null;

        b.gameObject.SetActive(false);

    }
    IEnumerator weapon()
    {
        yield return new WaitForSeconds(1f);
        weaponsound.Stop();
    }
    IEnumerator equipment()
    {
        yield return new WaitForSeconds(1f);
        equipmentsound.Stop();
    }

}
