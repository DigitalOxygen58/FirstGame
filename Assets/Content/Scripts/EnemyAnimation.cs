using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : MonoBehaviour
{
    public void SetDeathAnimation()
    {
        GetComponent<Animator>().SetTrigger("dead");
    }
}
