using UnityEngine;
using Oculus.Interaction.Locomotion;
using UnityEngine.XR;

public class TurnInteractionManager : MonoBehaviour
{
    [SerializeField] private TurnerEventBroadcaster turnerEventBroadcaster;
    private bool yButtonPrev = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turnerEventBroadcaster.TurnMethod = TurnerEventBroadcaster.TurnMode.Snap; // Cambia a Smooth para giro continuo
    }

    // Update is called once per frame
    void Update()
    {
       InputDevice leftHand = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
               if (leftHand.TryGetFeatureValue(CommonUsages.secondaryButton, out bool bButtonPressed))
        {
            // Detectar cuando se pulsa por primera vez (edge trigger)
            if (bButtonPressed && !yButtonPrev)
            {
                BroadcastTurnEvent(); // Llama al método para emitir el evento de giro
            }
            yButtonPrev = bButtonPressed; // Guardar estado actual
        }

    }

    public void BroadcastTurnEvent()
    {
        if(turnerEventBroadcaster.TurnMethod == TurnerEventBroadcaster.TurnMode.Snap)
        {
            turnerEventBroadcaster.TurnMethod = TurnerEventBroadcaster.TurnMode.Smooth;
        }
        else
        {
            turnerEventBroadcaster.TurnMethod = TurnerEventBroadcaster.TurnMode.Snap;
        }
    }
}
