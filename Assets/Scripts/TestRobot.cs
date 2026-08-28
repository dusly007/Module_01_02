using UnityEngine;

public class TestRobot : MonoBehaviour
{
    private void Awake(){
        Debug.Log("Awake: le robot est cree");
    }

    private void Start()
    {
        Debug.Log("Start: le jeu commence");
    }

    private void Update()
    {
        Debug.Log("Update: nouvelle image");
    }
}
