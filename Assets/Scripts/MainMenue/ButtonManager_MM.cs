using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager_MM : MonoBehaviour
{
    [SerializeField] private GameObject info_Panel;

    private bool infoPanel_toggle;

    private void Start()
    {
        if (info_Panel != null)
        {
            infoPanel_toggle = false;
            info_Panel.SetActive(false);
        }
    }

    public void OnRookie_Button()
    {
        GameManager.gameManager.scene_Numbers = 5;
        Reset_Stage();
        Fade_canvas.fader.FaderLoader_String("GamePlay");
    }

    public void OnMedium_Button()
    {
        GameManager.gameManager.scene_Numbers = 8;
        Reset_Stage();
        Fade_canvas.fader.FaderLoader_String("GamePlay");
    }

    public void OnProfessional_Button()
    {
        GameManager.gameManager.scene_Numbers = 10;
        Reset_Stage();
        Fade_canvas.fader.FaderLoader_String("GamePlay");
    }

    public void OnInfo_Button()
    {

        if (info_Panel != null)
        {
            infoPanel_toggle = !infoPanel_toggle;
            info_Panel.SetActive(infoPanel_toggle);
        }
    }

    private void Reset_Stage()
    {
        GameManager.gameManager._currentSceneIndex = 1;
        GameManager.gameManager.pass_turn_num = 0;
        GameManager.gameManager.fail_turn_num = 0;
        GameManager.gameManager._SpawnIndex = 2;
    }

    public void OnRetry_Button()
    {
        Fade_canvas.fader.FaderLoader_String("MainMenue");
    }
}
