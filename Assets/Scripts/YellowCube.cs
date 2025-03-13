using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Inheritance
public class YellowCube : Cube
{


    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 200;
        colourSelected = GameObject.Find("Colour Selected").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseOver()
    {
        RotateCube();
        DisplayColour();
    }
    private void OnMouseExit()
    {
        SetTextInactive();
    }
    // Polymorphism
    public override void RotateCube()
    {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }

}
