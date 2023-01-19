using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact_weapons : MonoBehaviour
{
    Outline outline;
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    private void OnMouseEnter() {
        outline.enabled = true;
    }

    private void OnMouseExit() {
        outline.enabled = false;
    }

}
