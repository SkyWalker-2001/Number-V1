using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager_MM : MonoBehaviour
{
    public void OnPressStart()
    {
        Fade_canvas.fader.FaderLoader_String("GamePlay");
    }
}
