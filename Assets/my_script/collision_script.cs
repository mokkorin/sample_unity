using UnityEngine;
using System.Collections;

public class collision_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision coli)
    {
        Debug.Log("collision");
        if(coli.transform.tag == "Player")
        {
            coli.gameObject.GetComponent<material_change_script>().coli_flag = true;
        }
    }
}
