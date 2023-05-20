using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiAttackController : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    void Attack()
    {
        anim.SetTrigger("Attack");
    }
}
