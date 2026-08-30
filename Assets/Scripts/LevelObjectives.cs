using UnityEngine;
using TMPro;


public class LevelObjectives : MonoBehaviour
{

    public GameObject levelObjectivesPanel;


    [Header("Objective 1")]
    public TMP_Text statusCount;

    public TMP_Text levelObjectDesc;

    private int destroysNeeded = 5;

    private int destroys = 0;

    [Header("Objective 2")]
    public GameObject objective2;
    


    private bool isActive;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isActive = false;
        levelObjectivesPanel.SetActive(isActive);

        statusCount.text = "5 remaining";
    }

    // Update is called once per frame
    void Update()
    {
       // Displaying Objectives whenever the player presses 'Tab'
        displayLevelObjectives();

        if (destroys >= destroysNeeded)
        {
            objective2.SetActive(true);
        }

    }

    private void displayLevelObjectives()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            levelObjectivesPanel.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Tab))
        {
            levelObjectivesPanel.SetActive(false);
        }
    }

    public void displayObjectivesMobile()
    {
        levelObjectivesPanel.SetActive(true);
    }

    


    public void incrementDestroyCount()
    {

        Debug.Log("Called Increment Destroy Count");
        destroys += 1;

        statusCount.text = ( destroysNeeded - destroys ) + " remaining";

        if (destroys >= destroysNeeded)
        {

            CompleteObjective1();
          

        }
    }

    public void CompleteObjective1()
    {
        statusCount.text = "0 remaining";

        levelObjectDesc.fontStyle = FontStyles.Strikethrough;
        statusCount.fontStyle = FontStyles.Strikethrough;

        objective2.SetActive(true);
    }

    public void CompleteObjective2()
    {
        
    }


}
