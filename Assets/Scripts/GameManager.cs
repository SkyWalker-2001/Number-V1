using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    [Header("SceneManager how many you want")]
    [SerializeField] public int scene_Numbers;
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

    private void EndGame_Screen()
    {
        if (scene_Numbers == _currentSceneIndex)
        {
            Debug.Log("EndScreen Scene KHATAM");
            Fade_canvas.fader.FaderLoader_String("EndGame");
        }
    }

    public void ButtonManager(int number)
    {
        ButtonManager_FN(number);
        if (_currentIndex == _SpawnIndex)
        {
            Next_Stage();
        }
    }

    private void Next_Stage()
    {
        pass_turn_num++;

        _currentIndex = 1;
        _currentSceneIndex++;
        _SpawnIndex++;


        SceneManager.LoadScene("GamePlay");
        Debug.Log("Next Stage in Next_Stage_FN");

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

        // changed it from 1 to 0 and bug which accept 2 two times solved NEED TESTING
        _currentIndex = 0;
        _currentSceneIndex++;
        _SpawnIndex++;
        SceneManager.LoadScene("GamePlay");
        Debug.Log("Move To Next Stage");

        EndGame_Screen();
    }

    public int Spawn_Quantity()
    {
        return _SpawnIndex;
    }
}
