using UnityEngine;

public class LeverController : MonoBehaviour
{
    private Transform leverTransform;

    void Start()
    {
        leverTransform = this.transform;
    }

    void Update()
    {
        // Obtén la rotación en grados
        float angleX = NormalizeAngle(leverTransform.localEulerAngles.x);

        if(angleX > 50f)
        {
            Debug.Log("Palanca activada");
        }
        else
        {
            Debug.Log("Palanca desactivada");
        }
    }

    // Convierte 0-360 a -180 a 180
    float NormalizeAngle(float angle)
    {
        if(angle > 180f)
            angle -= 360f;
        return angle;
    }
}