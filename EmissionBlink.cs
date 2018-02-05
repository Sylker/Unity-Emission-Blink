using System.Collections;
using UnityEngine;

public class EmissionBlink : MonoBehaviour 
{
    public Color color;
    [Range(.1f, 1)] public float intensity = .1f;
    [Range(.1f, 3)] public float speed = .1f;
    Renderer[] renderers;
    Coroutine blink;

    void Start()
    {
        renderers = transform.GetComponentsInChildren<Renderer>();
        foreach (Renderer skin in renderers)
            skin.material.EnableKeyword("_EmissionColor");
    }

    public void Blink()
    {
        if (blink != null) StopCoroutine(blink);
        blink = StartCoroutine(BlinkRoutine());
    }

    IEnumerator BlinkRoutine()
    {
        float emission = intensity;
        while (emission > 0.01f)
        {
            ChangeEmission(emission);
            emission -= speed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        ChangeEmission(0);
    }

    void ChangeEmission(float scale)
    {
        foreach (Renderer skin in renderers)
            skin.material.SetColor("_EmissionColor", color * scale);
    }
}
