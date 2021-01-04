using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdministradorJugadores : MonoBehaviour
{
    ControladorJugadores NumeroJugadores;
    private int jugadores;
    public GameObject jugador;
    public GameObject siguiente;
    public GameObject aceptar;
    private string nombreJugador;
    private List<string> listaJugadores;
  
    void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        listaJugadores=new List<string>();
        NumeroJugadores=FindObjectOfType<ControladorJugadores>();
         jugadores=NumeroJugadores.Jugadores;
         siguiente.SetActive(false);
         aceptar.SetActive(false);     
    }

      public void textJugador(int player){
        jugador.GetComponent<TextMeshProUGUI>().text = "player "+player ;
      }


    void Update()
    {

    }

    public void ingresarJugadores(string nombre){
        listaJugadores.Add(nombre);
    }

     public List<string> ListaJugadores   // property
  {
    get { return listaJugadores; }
    set { listaJugadores = value; }
  }

       public int  Jugadores  // property
  {
    get { return jugadores; }
    set { jugadores = value; }
  }

      public string  NombreJugador  // property
  {
    get { return nombreJugador; }
    set { nombreJugador = value; }
  }
    
}
