using UnityEngine;

public class zombieRadar : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Zombie iniciado");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrou algo: " + other.name);

        if (other.CompareTag("Personagem"))
        {
            Debug.Log("PERSONAGEM DETECTADO");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Dentro do Trigger: " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Saiu: " + other.name);
    }
}