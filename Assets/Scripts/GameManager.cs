using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    [Header("SceneManager how many you want")]
    [SerializeField] private int _scene_Numbers;
    public int _currentSceneIndex = 1;

    [Header("Scene Score Manager")]
    
    [SerializeField] public int pass_turn_num;
    [SerializeField] public int fail_turn_num;

    [Header("Spawner")]
    [SerializeField] private int _SpawnIndex;

    [Header("Screen Block")]
    [SerializeField] private int _SpawnCount;

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

    private void FixedUpdate()
    {
    }

    private void EndGame_Screen()
    {
        if (_scene_Numbers == _currentSceneIndex)
        {
            Debug.Log("EndScreen Scene KHATAM");
            Fade_canvas.fader.FaderLoader_String("EndGame");
        }
    }

    public void RestartGame()
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
        pass_turn_num++;

        _currentIndex = 1;
        _currentSceneIndex++;
        _SpawnIndex++;
        SceneManager.LoadScene("GamePlay");
        Debug.Log("WinCondition");

        EndGame_Screen();


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
        fail_turn_num++;

        _currentIndex = 1;
        _currentSceneIndex++;
        _SpawnIndex++;
        SceneManager.LoadScene("GamePlay");
        Debug.Log("WinCondition");

        EndGame_Screen();
    }

    public int Spawn_Quantity()
    {
        return _SpawnIndex;
    }
}
