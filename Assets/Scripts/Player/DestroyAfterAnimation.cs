using UnityEngine;

public class DestroyAfterAnimation : MonoBehaviour
{
    // Essa fun��o ser� chamada pela anima��o

    public GameObject levelUp;
    public void DestroyObject()
    {
        // Destrua o objeto atual
        Destroy(levelUp);
    }
}