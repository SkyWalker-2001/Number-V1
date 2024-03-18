using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Start_Manager : MonoBehaviour
{
    [SerializeField] private Canvas blockScreen_Canvas;
    [SerializeField] private TextMeshProUGUI timerBlockScreen;

    public float TimeLeft;
    private bool TimeOn = false;


    void Start()
    {
        TimeOn = true;
        blockScreen_Canvas.enabled = true;

        StartCoroutine(BLockScreenRoutine());
    }

    private void Update()
    {
        if (TimeOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                TimeOn = false;
            }
        }
    }

   private void updateTimer(float currentTime)
    {
        currentTime += 1;
        
        float second = Mathf.FloorToInt(currentTime % 60);

        timerBlockScreen.text = string.Format("{0:0}", second);
    }

    private IEnumerator BLockScreenRoutine()
    {
        yield return new WaitForSeconds(3);
        blockScreen_Canvas.enabled = false;
    }
}
