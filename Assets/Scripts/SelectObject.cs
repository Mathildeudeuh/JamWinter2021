using UnityEngine;

public class SelectObject : Select
{
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        // Si On entre en collision avec l'objet qui porte le tag "objectToFind"
        if (collision.tag.Equals("objectToFind"))
        {
            // Le booléen "isSelected" devient vrai
            isSelected = true;
        }
    }
}