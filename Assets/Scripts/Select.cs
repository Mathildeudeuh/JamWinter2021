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
                // La scène actuelle se désactive
                sceneToClose.SetActive(false);
                // La prochaine scène s'actiuve
                sceneToOpen.SetActive(true);
                // Le booléen redevient faux
                Debug.Log("c bon");
                // Si le booléen "isSelected" est vrai
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Si On entre en collision avec l'objet qui porte le tag "objectToFind"
        if (collision.tag.Equals("objectToFind"))
        {
            // Le booléen "isSelected" devient vrai
            isSelected = true;
        }
    }
}