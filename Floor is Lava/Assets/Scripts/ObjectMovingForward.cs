using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectMovingForward : MonoBehaviour
{
    [SerializeField] float _cycleLength = 1f;
    [SerializeField] float _zOscilation = 24f;
    void Start()
    {
        transform.DOMoveZ(_zOscilation, _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    
    void Update()
    {
        
    }
}
