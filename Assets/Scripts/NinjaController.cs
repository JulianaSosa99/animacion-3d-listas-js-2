using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    public GameObject NinjaProfesor; // Referencia al NinjaProfesor
    public List<GameObject> Estudiantes; // Lista de estudiantes

    private Animator ProfesorAnimator; // Animator del NinjaProfesor
    private List<Animator> EstudiantesAnimators; // Lista de Animators de los estudiantes

    void Start()
    {
        // Obtener el Animator del NinjaProfesor
        ProfesorAnimator = NinjaProfesor.GetComponent<Animator>();

        // Inicializar la lista de animadores de los estudiantes
        EstudiantesAnimators = new List<Animator>();
        foreach (GameObject estudiante in Estudiantes)
        {
            // Agregar el Animator de cada estudiante a la lista
            Animator animator = estudiante.GetComponent<Animator>();
            if (animator != null)
            {
                EstudiantesAnimators.Add(animator);
            }
        }
    }

    void Update()
    {
        // Detectar los movimientos del NinjaProfesor y sincronizarlos con los estudiantes
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Golpe1
        {
            ReproducirAnimacion("Golpe1");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // Golpe2
        {
            ReproducirAnimacion("Golpe2");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // Golpe3
        {
            ReproducirAnimacion("Golpe3");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4)) // Idle
        {
            ReproducirAnimacion("Idle2");
        }
    }

    void ReproducirAnimacion(string nombreAnimacion)
    {
        // Activar la animación en el NinjaProfesor
        ProfesorAnimator.SetTrigger(nombreAnimacion);

        // Activar la misma animación en todos los estudiantes
        foreach (Animator estudianteAnimator in EstudiantesAnimators)
        {
            estudianteAnimator.SetTrigger(nombreAnimacion);
        }
    }

}
