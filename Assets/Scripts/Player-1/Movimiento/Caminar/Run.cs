using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Referencia al script de movimiento que tiene el método publico 'SpeedMov' que define la velocidad de movimiento del objeto y lo cambia, el script debe llamarse igual")]
    private MovimientoPlayerStandar ScriptMovimiento;
    [SerializeField]
    [Tooltip("Modificador de velocidad")]
    private float SpeedRun;
    public Animator anim;
    
    void Update()
    {
        SpecialRun();
    }

    void SpecialRun(){
        if(Input.GetKey(KeyCode.LeftShift) && (Input.GetAxis("Vertical-P1") != 0)){
            ScriptMovimiento.SpeedMov = SpeedRun;
             anim.SetBool("run", true);
        }
        if(Input.GetKeyUp(KeyCode.LeftShift)){
            ScriptMovimiento.SpeedMov = 5f;
             anim.SetBool("run", false);
        }
    }
}
