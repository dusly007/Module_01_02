using UnityEngine;

public class RotationBatterie : MonoBehaviour
{
    [SerializeField] private float vitesseRotation = 90f; 

    private void Update()
    {
        transform.Rotate(
            0f,
            0f,
            vitesseRotation * Time.deltaTime
        );
    }   
}
