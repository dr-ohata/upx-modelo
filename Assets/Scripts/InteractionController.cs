using UnityEngine;

/// <summary>
/// Exemplo de extensão para interações do usuário.
/// </summary>
public class InteractionController : MonoBehaviour
{
    public void SelectObject(GameObject target)
    {
        if (target == null) return;
        Debug.Log($"Objeto selecionado: {target.name}");
    }
}
