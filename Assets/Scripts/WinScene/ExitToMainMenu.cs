using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitToMainMenu : MonoBehaviour
{
    public void ExitToMenu()
    {
       SceneManager.LoadSceneAsync("MainMenu");
    }
}
