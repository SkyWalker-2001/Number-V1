using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class End_Scene_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI pass_TMPro;
    [SerializeField] private TextMeshProUGUI fail_TMPro;

    private int _pass_Attempt;
    private int _fail_Attempt;
    private int _total_Scene_Index;

    private void Start()
    {
        Scene_Handlers();
        //Score_SYS();
    }

    private void Scene_Handlers()
    {
        _pass_Attempt = GameManager.gameManager.pass_turn_num;
        _fail_Attempt = GameManager.gameManager.fail_turn_num;
        _total_Scene_Index = GameManager.gameManager.scene_Numbers;

        pass_TMPro.text = _pass_Attempt.ToString();
        fail_TMPro.text = _fail_Attempt.ToString();
    }

    // private void Score_SYS(){
    //     switch (_total_Scene_Index)
    //     {
    //         case 5:
    //             Debug.Log("5");
    //             break;
    //         case 8:
    //             Debug.Log("8");
    //             break;
    //         case 10:
    //             Debug.Log("10");
    //             break;

    //         default:
    //             Debug.Log("Out of Bounds");
    //             break;
    //     }
    // }
}
