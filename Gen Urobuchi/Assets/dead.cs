using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dead : MonoBehaviour {


    public Slider healthbar;
    Animator anim;

    void OnTriggerEnter(Collider other)
    {
        healthbar.value -= 50;
        if (healthbar.value <= 0)
            anim.SetBool("Dead", true);
    }
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
