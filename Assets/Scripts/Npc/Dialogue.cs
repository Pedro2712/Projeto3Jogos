using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dialogue : MonoBehaviour
{
    public Sprite profile;
    public Canvas KeyF;
    public string[] speechTxt;
    public string actorName;

    public LayerMask playerLayer;
    public float radius;

    private DialogueControl dc;
    private bool onRadios;

    private void Start()
    {
        dc = FindObjectOfType<DialogueControl>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && onRadios && !dc.getisRunning())
        {
            dc.Speech(profile, speechTxt, actorName);
        }
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, playerLayer);

        onRadios = hit != null;

        // Ativa ou desativa o objeto keyspace com base na intera��o e no di�logo em andamento.
        if (KeyF != null)
        {
            KeyF.gameObject.SetActive(onRadios && !dc.getisRunning());
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
