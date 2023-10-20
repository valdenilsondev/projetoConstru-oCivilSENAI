using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interacao : MonoBehaviour
{
    public Camera cameraRayCast;
    private Rigidbody rbPlayer;
    public int distanceToMove = 10;
    private RaycastHit hit;

    public string[] falas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cameraRayCast.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));


        if (Physics.Raycast(ray, out hit, distanceToMove))
        {


            if (hit.collider.gameObject.tag == "escavadeira")
            {
                Debug.Log("Escavadeira");
            }

            Debug.DrawRay(ray.origin, ray.direction * distanceToMove, Color.red, 0.5f);

        }

    }
}
