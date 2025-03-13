using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PurpleCube : Cube
{
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 50;
        colourSelected = GameObject.Find("Colour Selected").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        //RotateCube is Inherited from Cube Class. This is also an example of abstraction as te rotate code is abstracted to its own method
        RotateCube();
        //DisplayColour is an overridden metheod
        DisplayColour();
    }
    // Polymorphism
    public override void DisplayColour()
    {
        colourSelected.gameObject.SetActive(true);
        colourSelected.text = "Cube is Purple";
    }
    private void OnMouseExit()
    {
        SetTextInactive();
    }
}
