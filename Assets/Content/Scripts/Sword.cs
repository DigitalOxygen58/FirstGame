using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Collider swordCollider;

    private void Awake()
    {
        swordCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "enemy")
        {
            other.GetComponent<EnemyDeath>().SetDeath();
        }
    }

    public void EnableAttack()
    {
        swordCollider.enabled = true;
    }

    public void DisableAttack()
    {
        swordCollider.enabled = false;
    }
}
