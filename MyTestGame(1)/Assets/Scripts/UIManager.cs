using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    void Awake()
    {
        StartGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
