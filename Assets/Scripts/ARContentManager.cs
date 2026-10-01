using UnityEngine;

/// <summary>
/// Exemplo de componente responsável por ativar conteúdo virtual.
/// </summary>
public class ARContentManager : MonoBehaviour
{
    [SerializeField] private GameObject exampleContent;

    public void ShowContent(string referenceName)
    {
        if (exampleContent == null)
        {
            Debug.LogWarning("Conteúdo de exemplo não configurado.");
            return;
        }

        exampleContent.SetActive(true);
        Debug.Log($"Conteúdo exibido para: {referenceName}");
    }
}
