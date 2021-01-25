using UnityEngine;
using System.Collections;

public class MoveX : MonoBehaviour {

	public float speed;
    public FadeInOut fio;
    public GameObject target;
    public bool ex;
    // Update is called once per frame
    void Update () {
        float step = speed * Time.deltaTime;
        if (Vector3.Distance(this.transform.position, target.transform.position) < 0.1f)
        {
            if (ex == false)
            {
                ex = true;
                fio.explo();
              
            }
        }
        else { this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, step); }
    }
}
