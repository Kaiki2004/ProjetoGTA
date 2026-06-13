using UnityEngine;
using UnityEngine.InputSystem;

public class DiaNoite : MonoBehaviour
{
    [Header("Luz Direcional")]
    [SerializeField] private Light luzDirecional;

    [Header("Configuração")]
    [SerializeField] private Color corDia = Color.white;
    [SerializeField] private Color corNoite = new Color(0.2f, 0.2f, 0.35f);

    [SerializeField] private float intensidadeDia = 1.2f;
    [SerializeField] private float intensidadeNoite = 0.2f;

    private bool estaNoite = false;

    private void Update()
    {
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            AlternarDiaNoite();
        }
    }

    private void AlternarDiaNoite()
    {
        estaNoite = !estaNoite;

        if (estaNoite)
        {
            RenderSettings.ambientLight = corNoite;

            luzDirecional.intensity = intensidadeNoite;
            luzDirecional.transform.rotation = Quaternion.Euler(340f, -30f, 0f);
        }
        else
        {
            RenderSettings.ambientLight = corDia;

            luzDirecional.intensity = intensidadeDia;
            luzDirecional.transform.rotation = Quaternion.Euler(50f, -30f, 0f);
        }
    }
}