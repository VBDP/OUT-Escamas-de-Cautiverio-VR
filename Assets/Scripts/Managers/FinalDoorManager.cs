using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class DetectRotationZ : MonoBehaviour
{
    private int puntuacionFinal;
    private ScoreManager ScoreManager;
    void Start()
    {
        ScoreManager = FindFirstObjectByType<ScoreManager>();
    }
    void Update()
    {
        Quaternion rotation = this.transform.localRotation;
        rotation.Normalize();
        float rotationZ = rotation.z;

        if(rotationZ <= -0.1f)
        {
            puntuacionFinal = ScoreManager.score;
           PlayerPrefs.SetInt("PuntuacionFinal", puntuacionFinal);
           SceneManager.LoadSceneAsync("WinScene");
        }
    }
}