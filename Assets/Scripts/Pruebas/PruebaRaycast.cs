using Unity.VisualScripting;
using UnityEngine;

public class PruebaRaycast : MonoBehaviour
{

public void OnHoverEnter()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
    public void OnHoverExit()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }

public void OnSelected()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }



    public void OnDeselected()
    {
       this.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
}

