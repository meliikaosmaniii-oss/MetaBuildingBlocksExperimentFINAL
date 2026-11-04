using UnityEngine;

public class FlowerBloom : MonoBehaviour
{
    public Renderer flowerRenderer;
    public Color glowColor = new Color(0.5f, 0.8f, 1f);
    public float glowIntensity = 2f;

    private bool bloomed = false;

    void OnTriggerEnter(Collider other)
    {
        if (bloomed || flowerRenderer == null) return;

        foreach (Material mat in flowerRenderer.materials)
        {
            mat.EnableKeyword("_EMISSION");
            mat.SetColor("_EmissionColor", glowColor * glowIntensity);
        }

        bloomed = true;
        Debug.Log("The flower has bloomed!");
    }
}