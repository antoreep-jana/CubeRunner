using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealthScript : MonoBehaviour
{
    
    public TMP_Text healthText;
    public float playerHealth = 100f;

    void Start()
    {
       healthText.text = playerHealth.ToString();
    }

    private void UpdateHealthText()
    {
        healthText.text = playerHealth.ToString();
    }


    public int GetHealth()
    {
        return Mathf.RoundToInt(playerHealth);
    }

    public void TakeDamage(float damageAmount)
    {
        playerHealth -= damageAmount;
        if (playerHealth < 0)
        {
            playerHealth = 0;
        }
        UpdateHealthText();
    }

    public void Heal(float healAmount)
    {
        playerHealth += healAmount;
        if (playerHealth > 100f)
        {
            playerHealth = 100f;
        }
        UpdateHealthText();
    }


}
