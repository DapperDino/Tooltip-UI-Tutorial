using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DapperDino.TooltipUI
{
    public class ItemButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private TooltipPopup tooltipPopup;
        [SerializeField] private Item item;

        public void OnPointerEnter(PointerEventData eventData)
        {
            tooltipPopup.DisplayInfo(item);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            tooltipPopup.HideInfo();
        }
    }
}
