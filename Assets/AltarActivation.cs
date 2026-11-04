
using UnityEngine;

public class AltarActivation : MonoBehaviour
{
    public GameObject mainCrystal;
    public Light altarLight;

    private bool activated = false;

    void OnTriggerEnter(Collider other)
    {
        if (activated || mainCrystal == null || altarLight == null)
            return;

        if (other.gameObject == mainCrystal ||
            other.transform.IsChildOf(mainCrystal.transform))
        {
            activated = true;

            Rigidbody rb = mainCrystal.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.isKinematic = true;
            }

            mainCrystal.transform.position =
                new Vector3(3.7f, 0.85f, 2.5f);

            altarLight.enabled = true;

            Debug.Log("The garden light has been restored!");
        }
    }
}
