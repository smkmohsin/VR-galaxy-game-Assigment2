using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MeteorController : GazePointer
{
    public GameObject particleEffect;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        PlayerManager.currentScore += 10;
        Burst();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Planet"))
        {
            PlayerManager.planetHealth -= 0.1f;
            //Debug.Log("Collided planet!");
            Burst();
        }
        else if(other.CompareTag("Meteor"))
            Burst();
    }

    public void Burst()
    {
        particleEffect.SetActive(true);
        particleEffect.transform.SetParent(null);
        Destroy(gameObject);
    }
}
