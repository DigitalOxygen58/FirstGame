using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public void SetDeath()
    {
        GetComponent<EnemyAnimation>().SetDeathAnimation();
        StartCoroutine(RemoveFromScene());
    }

    public IEnumerator RemoveFromScene()
    {
        Debug.Log("starting coroutine");
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
