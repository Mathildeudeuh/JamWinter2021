using UnityEngine;
using UnityEngine.InputSystem;

public class SelectFalse : MonoBehaviour
{
    private bool isSelectedFalse = false;
    [SerializeField] GameObject sceneToCloseFalse;
    [SerializeField] GameObject sceneToOpenFalse;


    private void Awake()
    {
        isSelectedFalse = false;
    } 

    public void SelectionFalse(InputAction.CallbackContext obj)
    {
        // Et si on appuie sur le bouton
        if (!obj.performed)
        {
            if (isSelectedFalse == true)
            {
                // La sc�ne actuelle se d�sactive
                sceneToCloseFalse.SetActive(false);
                // La prochaine sc�ne s'actiuve
                sceneToOpenFalse.SetActive(true);
                // Le bool�en redevient faux
                Debug.Log("c bon");
                // Si le bool�en "isSelected" est vrai
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si On entre en collision avec l'objet qui porte le tag "objectToFind"
        if (collision.tag.Equals("wrongObject"))
        {
            // Le bool�en "isSelected" devient vrai
            isSelectedFalse = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isSelectedFalse = false;
    }
}