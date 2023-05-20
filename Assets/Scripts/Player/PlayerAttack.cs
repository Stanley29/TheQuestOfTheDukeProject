using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damagePerHit = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Attack start");
            Attack(other);
            Debug.Log("Attack finish");
        }

    }

    void Attack(Collider other)
    {
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damagePerHit, other.transform.position);
        }
    }
}
