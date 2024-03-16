using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public GameObject objectPrefab;
    public int numberOfObjects = 10;
    public float spawnAreaWidth = 10f;
    public float spawnAreaHeight = 10f;

    void Start()
    {
        SpawnObjects();
    }

    void SpawnObjects()
    {
        for (int i = 0; i < numberOfObjects; i++)
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
