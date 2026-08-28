using UnityEngine;
 
public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;
 
    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (!autre.CompareTag("Player")) return;
        if (pointDepart == null)
        {
            Debug.LogError("PointDepart n'est pas assigné.");
            return;
        }
        autre.transform.position = pointDepart.position;
        Rigidbody2D rb = autre.attachedRigidbody;
        if (rb != null) rb.linearVelocity = Vector2.zero;
        Debug.Log("Zone interdite : retour au point de départ.");
    }
}