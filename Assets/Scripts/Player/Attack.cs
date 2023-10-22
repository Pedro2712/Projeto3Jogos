using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject HitBoxAttackTop;
    public GameObject HitBoxAttackRight;
    public GameObject HitBoxAttackLeft;
    public GameObject HitBoxAttackDown;

    public void EnableHitBoxAttackTop()
    {
        if (HitBoxAttackTop != null)
        {
            HitBoxAttackTop.SetActive(true);
        }
        else
        {
            Debug.LogWarning("HitBoxAttackTop n�o foi atribu�do no Inspector.");
        }
    }
    
    public void EnableHitBoxAttackRight()
    {
        if (HitBoxAttackRight != null)
        {
            HitBoxAttackRight.SetActive(true);
        }
        else
        {
            Debug.LogWarning("HitBoxAttackRight n�o foi atribu�do no Inspector.");
        }
    }
    
    public void EnableHitBoxAttackLeft()
    {
        if (HitBoxAttackLeft != null)
        {
            HitBoxAttackLeft.SetActive(true);
        }
        else
        {
            Debug.LogWarning("HitBoxAttackLeft n�o foi atribu�do no Inspector.");
        }
    }
    public void EnableHitBoxAttackDown()
    {
        if (HitBoxAttackDown != null)
        {
            HitBoxAttackDown.SetActive(true);
        }
        else
        {
            Debug.LogWarning("HitBoxAttackDown n�o foi atribu�do no Inspector.");
        }
    }

    public void DisableAll() {
        HitBoxAttackTop.SetActive(false);
        HitBoxAttackRight.SetActive(false);
        HitBoxAttackLeft.SetActive(false);
        HitBoxAttackDown.SetActive(false);
    }
}
