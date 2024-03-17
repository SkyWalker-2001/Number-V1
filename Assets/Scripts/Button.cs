using System.Collections;
using TMPro;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Button m_Button;
    [SerializeField] private Canvas card_Black;

    private void Start()
    {
        m_Button = GetComponent<Button>();
        card_Black.enabled = false;

        StartCoroutine(Canvas_Enable());
    }

    private IEnumerator Canvas_Enable()
    {
        yield return new WaitForSeconds(5);
        card_Black.enabled = true;
    }

    public void OnPress()
    {
        card_Black.enabled = false;
        int number = int.Parse(m_Button.GetComponentInChildren<TextMeshPro>().text);

        GameManager.gameManager.ButtonManager(number);
    }
}
