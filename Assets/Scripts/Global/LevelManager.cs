using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject _containerVictory;
    public static LevelManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void EnableVictoryScreen()
    {
        _containerVictory.SetActive(true);
    }
   
    public void HomeScene()
    {
        SceneManager.LoadScene("LVL_Main");
    }

}
