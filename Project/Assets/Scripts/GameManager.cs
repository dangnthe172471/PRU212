using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int currentEnergy;
    [SerializeField] private int energyHold = 3;
    [SerializeField] private GameObject boss;
    private bool callBoss = false;
    [SerializeField] private GameObject enemySpam;
    [SerializeField] private Image energyBar;



    [SerializeField] GameObject gameUI;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject overMenu;
    [SerializeField] private GameObject pauseMenu;



    void Start()
    {
        currentEnergy = 0;
        UpdateEnergyBar();
        boss.SetActive(false);
        MainMenu();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void addE()
    {
        if (callBoss)
        {
            return;
        };
        currentEnergy += 1;
        UpdateEnergyBar();
        if (currentEnergy == energyHold)
        {
            CallBoss();

        }
    }
    private void CallBoss()
    {
        callBoss = true;
        boss.SetActive(true);
        //enemySpam.SetActive(false);

        //hidden energyBar
        gameUI.SetActive(false);
    }
    private void UpdateEnergyBar()
    {
        if (energyBar != null)
        {
            float fill = Mathf.Clamp01((float)currentEnergy / (float)energyHold);
            energyBar.fillAmount = fill;
        }

    }
    public void MainMenu()
    {
        mainMenu.SetActive(true);
        pauseMenu.SetActive(false);
        overMenu.SetActive(false);

        Time.timeScale = 0f;
    }
    public void OverMenu()
    {
        overMenu.SetActive(true);
        pauseMenu.SetActive(false);

        mainMenu.SetActive(false);
        Time.timeScale = 0f;

    }
    public void PauseMenu()
    {
        pauseMenu.SetActive(true);
        overMenu.SetActive(false);
        mainMenu.SetActive(false);
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        pauseMenu.SetActive(false);
        overMenu.SetActive(false);
        mainMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        overMenu.SetActive(false);
        mainMenu.SetActive(false);
        Time.timeScale = 1f;
    }


}
