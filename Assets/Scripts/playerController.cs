using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    //Player movement vars
    [SerializeField] float playerSpeed = 5f;
    Vector2 lastClickPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player movement function
        if (Input.GetMouseButton(0)) 
        {
            lastClickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(lastClickPos.x, transform.position.y),
                playerSpeed* Time.deltaTime);

        }
    }
}
