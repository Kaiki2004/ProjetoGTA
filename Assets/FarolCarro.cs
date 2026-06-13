using UnityEngine;
using UnityEngine.InputSystem;

public class FarolCarro : MonoBehaviour
{
    [Header("Faróis")]
    [SerializeField] private Light farolEsquerdo;
    [SerializeField] private Light farolDireito;

    private bool farolLigado = false;

    private void Start()
    {
        farolEsquerdo.enabled = false;
        farolDireito.enabled = false;
    }

    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            AlternarFarol();
        }
    }

    private void AlternarFarol()
    {
        farolLigado = !farolLigado;

        farolEsquerdo.enabled = farolLigado;
        farolDireito.enabled = farolLigado;
    }
}