using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] public float enemySpeed = 10;
    [SerializeField] public float enemyMaxHealth = 100;
    [SerializeField] public float enemyCurrentHealth;

    [SerializeField] Rigidbody2D enemyRB;

    private void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    
    void FixedUpdate()
    {
        enemyRB.velocity = new Vector2(0, - enemySpeed);
    }
}
