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
                // La scène actuelle se désactive
                sceneToCloseFalse.SetActive(false);
                // La prochaine scène s'actiuve
                sceneToOpenFalse.SetActive(true);
                // Le booléen redevient faux
                Debug.Log("c bon");
                // Si le booléen "isSelected" est vrai
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si On entre en collision avec l'objet qui porte le tag "objectToFind"
        if (collision.tag.Equals("wrongObject"))
        {
            // Le booléen "isSelected" devient vrai
            isSelectedFalse = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isSelectedFalse = false;
    }
}