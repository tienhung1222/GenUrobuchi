using UnityEngine;
using System.Collections;

public class chase : MonoBehaviour {
    public Transform player;
    static Animator anim; 
	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Vector3.Distance(player.position, this.transform.position) < 10)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            anim.SetBool("Idle", false);
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.03f);
                anim.SetBool("Walking", true);
                anim.SetBool("Attacking", false);
            }
            else
            {
                anim.SetBool("Attacking", true);
                anim.SetBool("Walking", false);
            }
        }
        else
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Walking", false);
            anim.SetBool("Attacking", false);
        }     	
	}
}
