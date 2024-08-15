using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDmgFeedBack : MonoBehaviour
{
    [SerializeField] PlayerStatus playerStatus;
    [SerializeField] SpriteRenderer spriteRenderer; 

    void DmgFeedBack()
    {
        StartCoroutine(TriggerDmgFeedBack());
    }

    IEnumerator TriggerDmgFeedBack() 
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(1);
        spriteRenderer.color = Color.white;
    }

    private void Awake()
    {
        playerStatus.onRecieveDmg += DmgFeedBack;
    }
}
