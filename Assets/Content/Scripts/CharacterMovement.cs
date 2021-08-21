using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    Rigidbody characterRb;
    CharacterAttack characterAttack;
    public float speed = 0;
    public float rotationSpeed = 5;

    private void Awake()
    {
        characterRb = GetComponent<Rigidbody>();
        characterAttack = GetComponent<CharacterAttack>();
    }


    void Update()
    {
        if (characterAttack.isAttacking)
            return;

        if(Input.GetKey(KeyCode.W))
        {
            characterRb.velocity += transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles += new Vector3(0, -1, 0) * Time.deltaTime * rotationSpeed; 
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 1, 0) * Time.deltaTime * rotationSpeed;
        }
    }
}
