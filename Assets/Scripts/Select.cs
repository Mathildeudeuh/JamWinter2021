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
            // La scène actuelle se désactive
            sceneToClose.SetActive(false);
            // La prochaine scène s'actiuve
            sceneToOpen.SetActive(true);
            // Le booléen redevient faux
            Debug.Log("c bon");
            // Si le booléen "isSelected" est vrai
        }
    }

    public abstract void OnTriggerEnter2D(Collider2D collision);
}