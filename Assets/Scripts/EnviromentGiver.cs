using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentGiver : MonoBehaviour
{

    public GameObject food;
    public GameObject pole;
    public bool MakeStuff = false;

    void OnTriggerEnter(Collider col)
    {
        GameObject obj = col.transform.gameObject;
        InteractiveCharacter activechar = obj.GetComponent<InteractiveCharacter>();


        switch(col.tag)
        {
            case "gather":

                if(transform.tag=="resource")
                {
                    if(!activechar.HoldingOBJ)
                        {
                    GameObject temp = Instantiate(food,obj.transform.GetChild(0).transform.position,transform.rotation,obj.transform);
                    obj.GetComponent<InteractiveCharacter>().SendMessage("ObjMessage");
                    activechar.HoldingOBJ = true;
                    activechar.Busy = true;
                        }
                }else if(transform.CompareTag("maker"))
                {
                      if(activechar.HoldingOBJ)
                        {
                            Destroy(obj.transform.GetChild(1).gameObject);
                            activechar.HoldingOBJ = false;
                            activechar.Busy = false;
                        }
                }
            break;

            case "setter":
                //same for the setter
            break;

        }
    }
}
