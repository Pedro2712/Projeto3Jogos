using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToolTipManagement : MonoBehaviour
{
    public static ToolTipManagement Instance { get; private set; }
    public TextMeshProUGUI textComponent;
    public RectTransform backgroundRect;
    public float xOffset = 10.0f; // Define o valor do deslocamento em X

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }

    private void Update()
    {
        Vector2 mousePosition = Input.mousePosition;

        // Defina a posi��o do ToolTip com base no tamanho do texto e na posi��o do mouse
        Vector2 textSize = textComponent.GetPreferredValues();
        //float newWidth = textSize.x + 20; // Adicione algum espa�o de margem
        //backgroundRect.sizeDelta = new Vector2(newWidth, textSize.y + 20); // Adicione espa�o vertical tamb�m

        // Ajuste a posi��o para que a ponta esquerda inferior fique onde o mouse est�, movendo 10 pixels para a direita
        Vector3 newPosition = new Vector3(mousePosition.x + backgroundRect.rect.width/2, mousePosition.y + 20, 0f);
        transform.position = newPosition;
    }

    public void SetAndShowToolTip(string message)
    {
        textComponent.text = message;

        // Ajuste a largura do fundo com base no tamanho do texto
        Vector2 textSize = textComponent.GetPreferredValues();
        float newWidth = textSize.x + 20; // Adicione algum espa�o de margem
        backgroundRect.sizeDelta = new Vector2(newWidth, backgroundRect.sizeDelta.y);

        gameObject.SetActive(true);
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }
}