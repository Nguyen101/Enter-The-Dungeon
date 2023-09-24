using UnityEngine;
using UnityEngine.EventSystems;

public class CardHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float hoverHeight = 0.2f; // Set the desired hover height
    public float hoverSpeed = 0.1f; // Set the speed at which the card hovers

    private Vector3 originalPosition;

    void Start()
    {
        originalPosition = transform.position;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Vector3 targetPosition = originalPosition + new Vector3(0.0f, hoverHeight, 0.0f);
        transform.position = Vector3.Lerp(transform.position, targetPosition, hoverSpeed);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.position = Vector3.Lerp(transform.position, originalPosition, hoverSpeed);
    }
}
