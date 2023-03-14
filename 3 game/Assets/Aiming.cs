using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour
{
    public Animator animator;
    public Camera camera;
    Coroutine zoomCoroutine;
    public GameObject AimDot;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            animator.SetBool("Zoom_pistol", true);
            AimDot.SetActive(true);

            if (zoomCoroutine != null)
                StopCoroutine(zoomCoroutine);

            zoomCoroutine = StartCoroutine(aimFieldOfView(camera, 50, 0.3f));
        }
        if (Input.GetMouseButtonUp(1))
        {
            animator.SetBool("Zoom_pistol", false);
            AimDot.SetActive(false);

            if (zoomCoroutine != null)
                StopCoroutine(zoomCoroutine);

            zoomCoroutine = StartCoroutine(aimFieldOfView(camera, 60, 0.3f));
        }
    }

    IEnumerator aimFieldOfView(Camera targetCamera, float toView, float duration)
    {
        float counter = 0;
        float fromView = targetCamera.fieldOfView;

        while (counter < duration)
        {
            counter += Time.deltaTime;

            float viewTime = counter / duration;

            targetCamera.fieldOfView = Mathf.Lerp(fromView, toView, viewTime);

            yield return null;
        }
    }
}
