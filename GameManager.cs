using UnityEngine;


public class GameManager : MonoBehaviour
{

    public float gameOverDelay = 3f;
    bool gameOver = false;

    private GameManager gameManager;
    public Transform gameOverGUI;
    public Transform pausedMenu;
    public Transform inventoryTab;
    public Transform camera;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Paused();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InventoryUI();
        }
    }

    public void Paused()
    {
        if (pausedMenu.gameObject.activeInHierarchy == false)
        {
            pausedMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
            AudioListener.pause = true;
            camera.GetComponent<AdvanceCamera>().enabled = false;
        }
        else
        {
            pausedMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
            AudioListener.pause = false;
            camera.GetComponent<AdvanceCamera>().enabled = true;
        }
    }

    public void EndGame()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Invoke(nameof(GameOverGUI), gameOverDelay);
        }
        else
        {
            gameOver = false;
        }
    }

    public void GameOverGUI()
    {
        if (gameOverGUI.gameObject.activeInHierarchy == false)
        {
            gameOverGUI.gameObject.SetActive(true);
        }
        else
        {
            gameOverGUI.gameObject.SetActive(false);
        }
    }

    public void InventoryUI()
    {
        if (inventoryTab.gameObject.activeInHierarchy == false)
        {
            inventoryTab.gameObject.SetActive(true);
        }
        else
        {
            inventoryTab.gameObject.SetActive(false);
        }
    }
}


