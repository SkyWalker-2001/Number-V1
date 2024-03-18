using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    [Header("SceneManager how many you want")]
    [SerializeField] private int _scene_Numbers;
    public int _currentSceneIndex = 1;


    [Header("Spawner")]
    [SerializeField] private int _SpawnIndex;

    private int _currentIndex;
    
    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        _currentSceneIndex = 1;

    }

    private void Start()
    {
        _currentIndex = 1;
    }

    private void Update()
    {
       
    }

    public void ButtonManager(int number)
    {
        ButtonManager_FN(number);
        if (_currentIndex == _SpawnIndex)
        {
            Win_Condition();
        }
    }

    private void Win_Condition()
    {
        _currentIndex = 1;
        _currentSceneIndex++;
        _SpawnIndex++;
        SceneManager.LoadScene("GamePlay");
        Debug.Log("WinCondition");

    }

    private void ButtonManager_FN(int number)
    {
        

        if (_currentIndex == number)
        {
            Debug.Log("CarryON");
        }

        else
        {
            GameOver();
        }

        _currentIndex++;
    }

    private void GameOver()
    {
        Debug.Log(_currentIndex);
        Debug.Log(_SpawnIndex);
        Debug.Log(_currentSceneIndex);
        Debug.Log("GAME OVER WRONG SEQUENCE");
    }

    public int Spawn_Quantity()
    {
        return _SpawnIndex;
    }
}
