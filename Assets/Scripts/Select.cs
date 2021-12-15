using UnityEngine;
using UnityEngine.InputSystem;

public class Select : MonoBehaviour
{
    [HideInInspector] public bool isSelected = false;
    [SerializeField] GameObject sceneToClose;
    [SerializeField] GameObject sceneToOpen;

    public void Selection(InputAction.CallbackContext obj)
    {
        // Et si on appuie sur le bouton
        if (!obj.performed)
        { 
            if (isSelected == true)
            {
                // La sc�ne actuelle se d�sactive
                sceneToClose.SetActive(false);
                // La prochaine sc�ne s'actiuve
                sceneToOpen.SetActive(true);
                // Le bool�en redevient faux
                Debug.Log("c bon");
                // Si le bool�en "isSelected" est vrai
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Si On entre en collision avec l'objet qui porte le tag "objectToFind"
        if (collision.tag.Equals("objectToFind"))
        {
            // Le bool�en "isSelected" devient vrai
            isSelected = true;
        }
    }
}