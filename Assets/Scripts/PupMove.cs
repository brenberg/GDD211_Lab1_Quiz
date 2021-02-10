using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PupMove : MonoBehaviour
{
    public float walkSpeed;
    public float Speed;
    public Animator pupAnimator;

    // Update is called once per frame
    void Update()
    {

        walkSpeed = Speed * 0.01f; 

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x + walkSpeed, transform.position.y, transform.position.z);
            pupAnimator.SetBool("WalkCheck", true);
        }

        else
        {
            pupAnimator.SetBool("WalkCheck", false);
        }
    }
}
