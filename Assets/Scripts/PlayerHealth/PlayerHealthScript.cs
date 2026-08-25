using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealthScript : MonoBehaviour
{
    
    public TMP_Text healthText;
    public int playerHealth = 100;

    void Start()
    {
        // Check for any saved file
        // PlayerData data = PlayerSaveManager.Load();

        // if (data == null)
        // {
        //     Debug.LogWarning("Save data could not be loaded");
        //     // return;
        //     playerHealth = 100f;
        // }
        // else
        // {
        //     playerHealth = data.health;
        // }



    //    healthText.text = playerHealth.ToString();
    }



    // private void UpdateHealthText()
    // {
    //     healthText.text = playerHealth.ToString();
    // }

    void Update()
    {
        healthText.text = playerHealth.ToString();
    }


    public int GetHealth()
    {
        return Mathf.RoundToInt(playerHealth);
    }

    public void SetHealth(int health)
    {
        playerHealth = health;
    }

    public void TakeDamage(int damageAmount)
    {
        playerHealth -= damageAmount;
        if (playerHealth < 0)
        {
            playerHealth = 0;
        }
        // UpdateHealthText();
    }

    public void Heal(int healAmount)
    {
        playerHealth += healAmount;
        if (playerHealth > 100)
        {
            playerHealth = 100;
        }
        // UpdateHealthText();
    }


}
