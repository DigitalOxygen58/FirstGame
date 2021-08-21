using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    public Animator anim;
    public Rigidbody characterRb;


    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", characterRb.velocity.magnitude);
    }

    public void SetAttackAnimation()
    {
        anim.SetTrigger("attack");
    }
}
