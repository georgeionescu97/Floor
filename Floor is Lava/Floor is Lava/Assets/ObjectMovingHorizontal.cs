using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectMovingHorizontal : MonoBehaviour
{
    [SerializeField] float _cycleLength = .5f;
    [SerializeField] float _zOscilation = 8f;
    void Start()
    {
        transform.DOMoveX(_zOscilation, _cycleLength).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}

