using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
   
    public GameObject _container;
    public static PlayerRespawn instance;

    private void Awake()
    {
        instance = this;
    }

    public void EnableDeathScreen()
    {
        _container.SetActive(true);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
