using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Button : GameManager
{
    [SerializeField] private Button m_Button;
    [SerializeField] private Canvas card_Black;

    protected override void Start()
    {
        base.Start();
        m_Button = GetComponent<Button>();
        //card_Black = GetComponent<GameObject>();
    }

    public void OnPress()
    {
        card_Black.enabled = false;
        int number = int.Parse(m_Button.GetComponentInChildren<TextMeshPro>().text);
        Debug.Log(number);
    }

 
}
