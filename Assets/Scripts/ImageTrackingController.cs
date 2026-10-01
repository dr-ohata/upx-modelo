using UnityEngine;

/// <summary>
/// Exemplo didático de ponto de entrada para tratamento de eventos de Image Tracking.
/// A equipe deve substituir este arquivo pela implementação real utilizada no projeto.
/// </summary>
public class ImageTrackingController : MonoBehaviour
{
    [SerializeField] private ARContentManager contentManager;

    public void OnReferenceDetected(string referenceName)
    {
        Debug.Log($"Referência detectada: {referenceName}");
        contentManager.ShowContent(referenceName);
    }

    public void OnReferenceLost(string referenceName)
    {
        Debug.Log($"Referência perdida: {referenceName}");
    }
}
