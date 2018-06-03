using UnityEngine;
using System.Collections;

public class material_change_script : MonoBehaviour {

    public Material red, blue;
    public bool coli_flag;
    // Use this for initialization
    void Start()
    {
        coli_flag = false;
    }
	
	// Update is called once per frame
	void Update () {


        if (coli_flag)
        {
            GetComponent<Renderer>().material = blue;
        }


	}
}
