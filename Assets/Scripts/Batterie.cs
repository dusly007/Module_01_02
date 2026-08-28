using UnityEngine;

public class Batterie : MonoBehaviour
{
    [SerializeField] private int valeur = 1;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (!autre.CompareTag("Player"))
            return;

        if (GestionJeu.Instance == null)
        {
            Debug.LogError(
                "Aucun GestionJeu n’est present dans la scene."
            );
            return;
        }

        GestionJeu.Instance.AjouterBatterie(valeur);
        Destroy(gameObject);
    }

    
}
