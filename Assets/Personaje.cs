using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public int NivelHambre;
    public AlimentoScipt alimento;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    void TomarAlimento(int valorAlimentario)
    {



        NivelHambre -= valorAlimentario;
        if(NivelHambre <= 0)

        {

            NivelHambre = 0;

        }



        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        AlimentoScipt alimento;
        alimento = other.GetComponent<AlimentoScipt>();
        TomarAlimento(alimento.valorAlimentario);
    }
}
