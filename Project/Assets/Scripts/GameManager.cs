using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private int currentEnergy;
    [SerializeField] private int energyHold = 3;
    [SerializeField] private GameObject boss;
    private bool callBoss = false;
    [SerializeField] private GameObject enemySpam;
    [SerializeField] private Image energyBar;
    [SerializeField] private GameObject[] panels;


    [SerializeField] GameObject mana;




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
        mana.SetActive(false);


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
        //mainMenu.SetActive(true);
        //pauseMenu.SetActive(false);
        //overMenu.SetActive(false);

        ShowPanelByName("MainMenu");
        Time.timeScale = 0f;
    }
    public void OverMenu()
    {
        ShowPanelByName("GameOver");
        Time.timeScale = 0f;

    }
    public void PauseMenu()
    {
        ShowPanelByName("GamePause");
        Time.timeScale = 0f;
    }
    public void StartGame()
    {

        ShowPanelByName("");
        Time.timeScale = 1f;
    }
    public void ResumeGame()
    {
        ShowPanelByName("");
        Time.timeScale = 1f;
    }  

    public void Shop()
    {
        ShowPanelByName("Shop");
        Time.timeScale = 0f;
    }
    public void Home()
    {
        ShowPanelByName("Home");
        Time.timeScale = 0f;
    }
    public void UpGrade()
    {
        ShowPanelByName("UpGrade");
        Time.timeScale = 0f;
    }
    public void Save_Quit()
    {
        enemyManager.Instance.SaveEnemies();
        playerData.Instance.SavePlayer();
        ShowPanelByName("Home");
        Time.timeScale = 0f;
    } public void Quit()
    {

        ShowPanelByName("Home");
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
     
        string enemyPath = Path.Combine(Application.dataPath, "enemyData.json");
        string playerPath = Path.Combine(Application.dataPath, "playerData.json");

        if (File.Exists(enemyPath))
        {
            File.Delete(enemyPath);
        }

        if (File.Exists(playerPath))
        {
            File.Delete(playerPath);
        }
        //mana.SetActive(false);
        //ShowPanelByName("");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;

    }


    public void ShowPanelByName(string panelName)
    {
        // Ẩn tất cả panel
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }

        mana.SetActive(true);
        // Hiển thị panel có tên tương ứng
        foreach (GameObject panel in panels)
        {
            if (panel.name == panelName)
            {
                panel.SetActive(true);

                return;
            }
        }
    }

}
