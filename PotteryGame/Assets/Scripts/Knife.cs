using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    [SerializeField] private float hitDamage;
    [SerializeField] private Wood wood;
    [SerializeField] private ParticleSystem woodFX;
    private ParticleSystem.EmissionModule woodFxEmission;
    private bool isMoving = false;
    private Camera cam;

    private void Start()
    {
        woodFxEmission = woodFX.emission;
        cam = Camera.main;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isMoving = false;
        }
        if (isMoving)
        {
             Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
             Vector3 objPosition = cam.ScreenToWorldPoint(mousePosition);
             transform.position = objPosition;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        WoodCol woodCol = collision.collider.GetComponent<WoodCol>();
        if (woodCol != null)
        {
            woodFxEmission.enabled = true;
            woodFX.transform.position = collision.contacts[0].point;
            woodCol.HitCollider(hitDamage);
            wood.Hit(woodCol.index, hitDamage);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        woodFxEmission.enabled = false;
    }
}
