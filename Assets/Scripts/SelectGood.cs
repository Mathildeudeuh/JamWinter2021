using UnityEngine;
using UnityEngine.InputSystem;

public class SelectGood : MonoBehaviour
{
    private bool isSelectedGood = false;
    [SerializeField] GameObject sceneToCloseGood;
    [SerializeField] GameObject sceneToOpenGood;

    public void SelectionGood(InputAction.CallbackContext obj)
    {
        // Et si on appuie sur le bouton
        if (!obj.performed)
        {
            if (isSelectedGood == true)
            {
                // La scène actuelle se désactive
                sceneToCloseGood.SetActive(false);
                // La prochaine scène s'actiuve
                sceneToOpenGood.SetActive(true);
                // Le booléen redevient faux
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si On entre en collision avec l'objet qui porte le tag "objectToFind"
        if (collision.tag.Equals("objectToFind"))
        {
            // Le booléen "isSelected" devient vrai
            isSelectedGood = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isSelectedGood = false;
    }
}