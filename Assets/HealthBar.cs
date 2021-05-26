using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float playerMaxHealth = 100;
    public float playerCurrentHealth;

    [SerializeField] Slider healthBarSlider;

    private void Awake()
    {
        playerCurrentHealth = playerMaxHealth;
        healthBarSlider.maxValue = playerMaxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerCurrentHealth -= 5;
        }

        healthBarSlider.value = playerCurrentHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemyBullet")
        { 
            
        }
    }
}
