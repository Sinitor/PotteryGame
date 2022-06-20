using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Wood : MonoBehaviour
{
    [SerializeField] private Transform wood;
    [SerializeField] private Vector3 rotationVec;
    [SerializeField] private float rotationDuration;
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;

    private void Start()
    {
        wood.DOLocalRotate(rotationVec, rotationDuration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    } 
    public void Hit(int keyIndex, float damage)
    {
        float colliderHeight = 2.853788f;
        float newWeight = skinnedMeshRenderer.GetBlendShapeWeight(keyIndex) + damage * (100f/ colliderHeight); 
        skinnedMeshRenderer.SetBlendShapeWeight(keyIndex, newWeight);
    }
}
