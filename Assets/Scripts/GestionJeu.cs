using UnityEngine;
 
public class GestionJeu : MonoBehaviour
{
    public static GestionJeu Instance { get; private set; }
 
    [SerializeField] private int objectif = 3;
    [SerializeField] private GameObject porte;
 
    private int batteriesCollectees = 0;
    private bool objectifAtteint = false;
 
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
 
        Instance = this;
    }
 
    private void Start()
    {
        if (porte == null)
        {
            Debug.LogError(
                "La porte n'est pas configurée dans l'Inspector."
            );
            return;
        }
 
        // La porte est invisible au début.
        porte.SetActive(false);
    }
 
    public void AjouterBatterie(int valeur)
    {
        batteriesCollectees += valeur;
 
        Debug.Log(
            $"Batteries : {batteriesCollectees}/{objectif}"
        );
 
        if (batteriesCollectees >= objectif && !objectifAtteint)
        {
            objectifAtteint = true;
            OuvrirPorte();
        }
    }
 
    private void OuvrirPorte()
    {
        if (porte == null)
            return;
 
        porte.SetActive(true);
 
        Debug.Log(
            "Objectif atteint : la porte est maintenant accessible !"
        );
    }
 
    private void OnTriggerEnter2D(Collider2D autre)
    {
        // Le joueur disparaît seulement si l'objectif est atteint.
        if (objectifAtteint && autre.CompareTag("Player"))
        {
            Debug.Log("Le joueur a atteint la sortie !");
            Destroy(autre.gameObject);
        }
    }
}
