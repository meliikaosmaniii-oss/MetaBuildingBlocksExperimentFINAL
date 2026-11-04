
using UnityEngine;

public class DayNightController : MonoBehaviour
{
    public Light directionalLight;

    public bool isDay = false;

    void Start()
    {
        ApplyLighting();
    }

    public void ToggleDayNight()
    {
        isDay = !isDay;
        ApplyLighting();
    }

    void ApplyLighting()
    {
        if (directionalLight != null)
        {
            directionalLight.intensity = isDay ? 1.8f : 1.2f;
            directionalLight.color = isDay
                ? new Color(1f, 0.94f, 0.82f)
                : new Color(0.86f, 0.89f, 1f);
        }

        RenderSettings.ambientLight = isDay
            ? new Color(0.75f, 0.78f, 0.82f)
            : new Color(0.60f, 0.67f, 0.78f);
    }
}
