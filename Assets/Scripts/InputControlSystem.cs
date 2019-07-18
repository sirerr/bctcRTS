using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlSystem : MonoBehaviour
{
    public static InputControlSystem inputsystem;
    Vector2 mousePos;
    Ray CamRay;
    //current object selected
  public  GameObject CurrentObject;

    private void Awake()
    {
        inputsystem = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Input.GetMouseButtonDown(0))
        {
            SelectObj();
        }
    }

    void SelectObj()
    {
        RaycastHit rayhit;
        mousePos = Input.mousePosition;
        CamRay = Camera.main.ScreenPointToRay(mousePos);

        if (Physics.Raycast(CamRay, out rayhit, Mathf.Infinity))
        {
            CurrentObject = rayhit.transform.gameObject;
            print(rayhit.transform.tag);
        }
    }
}
