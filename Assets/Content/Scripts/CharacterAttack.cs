using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAttack : MonoBehaviour
{
    public bool isAttacking = false;
    CharacterAnimation anim;
    public Sword currentWeapon;

    private void Awake()
    {
        anim = GetComponent<CharacterAnimation>();
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetAttackAnimation();
        }

    }

    public void AttackStart()
    {
        isAttacking = true;
        currentWeapon.EnableAttack();
    }

    public void AttackEnd()
    {
        isAttacking = false;
        currentWeapon.DisableAttack();
    }
}
