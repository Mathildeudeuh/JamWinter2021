using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Select : MonoBehaviour
{
    [HideInInspector] public bool isSelected = false;
    [SerializeField] GameObject sceneToClose;
    [SerializeField] GameObject sceneToOpen;

    public void Selection(InputAction.CallbackContext obj)
    {
        // Et si on appuie sur le bouton
        if (!obj.performed)
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

    public abstract void OnTriggerEnter2D(Collider2D collision);
}