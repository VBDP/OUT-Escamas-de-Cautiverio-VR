using TMPro;
using UnityEngine;
using UnityEngine.XR;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public int score = 5000;
    private float timer = 0f;

    private bool hudActive = false; // Por defecto desactivado
    private bool bButtonPrev = false; // Para detectar cambios de estado

    void Start()
    {
        // Inicializar puntuación
        scoreText.text = "Score: " + score;
        scoreText.gameObject.SetActive(hudActive); // Asegurarse de que esté desactivado al inicio
    }

    void Update()
    {
        // 1️⃣ Actualizar puntuación cada segundo
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            if (score > 0)
                score -= 1;

            timer = 0f;
        }

        // 2️⃣ Actualizar texto solo si está activo
        scoreText.gameObject.SetActive(hudActive);
        if (hudActive)
            scoreText.text = "Score: " + score;

        // 3️⃣ Detectar botón B del mando derecho
        InputDevice rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        if (rightHand.TryGetFeatureValue(CommonUsages.secondaryButton, out bool bButtonPressed))
        {
            // Detectar cuando se pulsa por primera vez (edge trigger)
            if (bButtonPressed && !bButtonPrev)
            {
                hudActive = !hudActive; // Cambiar estado
            }
            bButtonPrev = bButtonPressed; // Guardar estado actual
        }
    }
}