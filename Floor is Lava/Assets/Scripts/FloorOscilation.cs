using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class FloorOscilation : MonoBehaviour
{
    [SerializeField] float _cycleLength = 1f;
    [SerializeField] float _zOscilation = 24f;
    public GameObject player;
    void Start()
    {
        transform.DOMoveY(_zOscilation, _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == player)
        {
            player.transform.parent = this.gameObject.transform;
        }
    }

   


}
