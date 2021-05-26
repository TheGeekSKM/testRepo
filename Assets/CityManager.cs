using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityManager : MonoBehaviour
{
    [SerializeField] HealthBar healthBar;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            healthBar.playerCurrentHealth -= 10;
            Destroy(collision.gameObject);
        }
    }


}
