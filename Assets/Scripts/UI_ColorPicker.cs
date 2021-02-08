using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_ColorPicker : MonoBehaviour
{
    //[SerializeField] private GameObject target;
    [SerializeField] private SpriteRenderer targetMaterial;
    [SerializeField] private GraphicRaycaster graphicRaycaster;
    private PointerEventData pointerEventData;
    [SerializeField] private EventSystem eventSystem;
    private Color color;

    private void Update()
    {
        pointerEventData = new PointerEventData(eventSystem);
        pointerEventData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        graphicRaycaster.Raycast(pointerEventData, results);

        foreach(RaycastResult swath in results)
        {
            color = swath.gameObject.GetComponent<Image>().color;

            if (color != null)
            {
                targetMaterial.color = color;
            }
        }
    }
}
