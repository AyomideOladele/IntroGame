using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PaddleMove : MonoBehaviour
{

    private float _direction; //-1 or 1 depending on direction we're moving
    public float moveSpeed; //Speed multiplier which shows up in editor due to public accessor
    public float minX, maxX;

    
    public void OnMove(InputValue value)
    {
        _direction = value.Get<float>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x + (_direction * moveSpeed * Time.deltaTime);
        float clampedX = Mathf.Clamp(newX, minX, maxX); // Prevents paddle from going through walls
        transform.position = new Vector3(clampedX, y:0.15f, z:0); // Set paddle position
    } 
}

//We want the move speed to be codeable by the developer in the editor, therefore we don't want to hardcode it into the script
