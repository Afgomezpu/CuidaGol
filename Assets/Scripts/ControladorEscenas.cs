using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void PreguntasEscena() {
        SceneManager.LoadScene("Preguntas");
    }
    public void PenaltiEscena() {
        SceneManager.LoadScene("Penalti");
    }
    public void VeintiUnaEscena() {
        SceneManager.LoadScene("VeintiUna");
    }
    public void PrincipalEscena() {
        SceneManager.LoadScene("Principal");
    }
    public void SeleccionEscena() {
        SceneManager.LoadScene("Seleccion");
    }
     public void MainEscena() {
        SceneManager.LoadScene("MainScene");
    }
     public void TutorialEscena() {
        SceneManager.LoadScene("VideoTutorial");
    }
      public void JugadoresEscena() {
        SceneManager.LoadScene("NumeroJugadores");
    }
      public void seleccionavatar() {
        SceneManager.LoadScene("seleccionavatar");
    }

      public void KinectAvatarYPreguntas() {
        SceneManager.LoadScene("KinectAvatarsDemo1");
    }

      public void Puntuacion() {
        SceneManager.LoadScene("Puntuacion");
    }
    public void ExitGame() {
        Application.Quit();
    }
}
