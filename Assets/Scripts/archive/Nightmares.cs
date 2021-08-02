using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nightmares : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;

    [SerializeField] private float maxX;
    [SerializeField] private float minX;
    [SerializeField] private float maxY;
    [SerializeField] private float minY;

    [SerializeField]    private float scaleAmount = 1.1f;
    private Vector3 originalScale;
    private float distance;


    


    private void Awake()
    {
        originalScale = transform.localScale;
    }

    void Start()
    {
        
    }

    private void FixedUpdate()

    {
        Move();
        distance = Vector3.Distance(Camera.main.transform.position, transform.position);
        var diffVector =distance/scaleAmount;
        //transform.localScale = originalScale * diffVector;
    }
    private void Move()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        transform.position = transform.position + Camera.main.transform.forward *randomY* speed * Time.deltaTime + Camera.main.transform.right * randomX * speed * Time.deltaTime;
    }
   
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Border")
            Destroy(this.gameObject);
    }

}
