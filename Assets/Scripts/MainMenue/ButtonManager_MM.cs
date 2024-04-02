using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager_MM : MonoBehaviour
{
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
