using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public static Spawner spawner;

    [SerializeField] private TextMeshProUGUI scene_Number;
    [SerializeField] private TextMeshProUGUI pass_Text;
    [SerializeField] private TextMeshProUGUI fail_Text;
    [SerializeField] private TextMeshProUGUI stage_Info;


    public GameObject objectPrefab;
    public float spawnAreaWidth = 10f;
    public float spawnAreaHeight = 10f;

    private void Awake()
    {
        spawner = this;
    }

    void Start()
    {
        int spawn_Quantity = GameManager.gameManager.Spawn_Quantity();

        SpawnObjects(spawn_Quantity - 1);

        int scene_Number = GameManager.gameManager._currentSceneIndex;
        int pass_Num_Text = GameManager.gameManager.pass_turn_num;
        int fail_Num_Text = GameManager.gameManager.fail_turn_num;
        int total_Scene_Number = GameManager.gameManager.scene_Numbers;

        this.scene_Number.text = $"{scene_Number} / {total_Scene_Number - 1}" ;
        pass_Text.text = pass_Num_Text.ToString();
        fail_Text.text = fail_Num_Text.ToString();
        stage_Info.text = $"Please click/tap from 1 to {scene_Number}";

    }

    void SpawnObjects(int spawn_Quantity)
    {
        for (int i = 0; i < spawn_Quantity; i++)
        {
            Vector2 randomPosition = GetRandomPosition();
            GameObject newObject = Instantiate(objectPrefab, randomPosition, Quaternion.identity);

            TextMeshPro textMeshPro = newObject.GetComponentInChildren<TextMeshPro>(true);
            if (textMeshPro != null)
            {
                textMeshPro.text = (i + 1).ToString();
            }
            else
            {
                Debug.LogWarning("TextMeshPro component not found in children of prefab.");
            }

            // Adjust position to prevent overlap
            Collider2D[] colliders = Physics2D.OverlapBoxAll(randomPosition, newObject.transform.localScale, 0);
            foreach (Collider2D collider in colliders)
            {
                if (collider.gameObject != newObject)
                {
                    randomPosition = GetRandomPosition();
                    newObject.transform.position = randomPosition;
                    colliders = Physics2D.OverlapBoxAll(randomPosition, newObject.transform.localScale, 0);
                }
            }
        }
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(-spawnAreaWidth / 2f, spawnAreaWidth / 2f);
        float randomY = Random.Range(-spawnAreaHeight / 2f, spawnAreaHeight / 2f);
        return new Vector2(randomX, randomY);
    }


}
