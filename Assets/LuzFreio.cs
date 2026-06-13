using UnityEngine;
using UnityEngine.InputSystem;

public class LuzFreio : MonoBehaviour
{
    [Header("Luzes de Freio")]
    [SerializeField] private Light luzFreioEsquerda;
    [SerializeField] private Light luzFreioDireita;

    private void Start()
    {
        luzFreioEsquerda.enabled = false;
        luzFreioDireita.enabled = false;
    }

    private void Update()
    {
        bool freando = Keyboard.current.spaceKey.isPressed;

        luzFreioEsquerda.enabled = freando;
        luzFreioDireita.enabled = freando;
    }
}