using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class OnRuneTriggerEnter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.name)
        {
            case "Jera TP Point":
                if (gameObject.name == "Jera")
                {
                    TeleportToTrigger(other);
                }
                break;

            case "Othilla TP Point":
                if (gameObject.name == "Othilla")
                {
                    TeleportToTrigger(other);
                }
                break;
        }
    }

    private void TeleportToTrigger(Collider trigger)
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.isKinematic = true;

        transform.position = trigger.transform.position;
        transform.rotation = trigger.transform.rotation;

        rb.isKinematic = false;
    }
}