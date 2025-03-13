using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Cube : MonoBehaviour
{
    public float rotationSpeed;
    public TextMeshProUGUI colourSelected;
    public TextMeshProUGUI encapsulationObject;
    //Encapsulation
    public string encapsulationText {  get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        encapsulationObject = GameObject.Find("Encapsulation").GetComponent<TextMeshProUGUI>();
        encapsulationText = "This text is an example of encapsulation. Hover mouse over cubes";
        encapsulationObject.text = encapsulationText;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void RotateCube()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
    public virtual void DisplayColour()
    {
        colourSelected.gameObject.SetActive(true);
        colourSelected.text = "Cube is Yellow";
    }
    public void SetTextInactive()
    {
        colourSelected.gameObject.SetActive(false);
    }
    private void SetEncapText()
    {
        
    }
}
