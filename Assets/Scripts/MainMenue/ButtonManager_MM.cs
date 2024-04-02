using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager_MM : MonoBehaviour
{
    public void OnRookie_Button()
    {
        GameManager.gameManager.scene_Numbers = 5;
        Fade_canvas.fader.FaderLoader_String("GamePlay");
    }

    public void OnMedium_Button()
    {
        GameManager.gameManager.scene_Numbers = 8;
        Fade_canvas.fader.FaderLoader_String("GamePlay"); 
    }

    public void OnProfessional_Button()
    {
        GameManager.gameManager.scene_Numbers = 10;
        Fade_canvas.fader.FaderLoader_String("GamePlay");
    }
}
