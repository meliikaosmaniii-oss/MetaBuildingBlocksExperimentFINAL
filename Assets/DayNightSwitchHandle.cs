
using UnityEngine;
using System.Collections;

public class DayNightSwitchHandle : MonoBehaviour
{
    public DayNightController controller;

    private Vector3 startPosition;
    private bool hasSwitched = false;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, startPosition);

        if (distance > 0.15f && !hasSwitched)
        {
            hasSwitched = true;
            controller.ToggleDayNight();
            StartCoroutine(ReturnButton());
        }
    }

    IEnumerator ReturnButton()
    {
        yield return new WaitForSeconds(0.5f);

        transform.position = startPosition;
        hasSwitched = false;
    }
}
