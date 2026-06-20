using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] Image slotItemImage;
    [SerializeField] GameObject slotItemObject;
    [SerializeField] TextMeshProUGUI slotItemName;

    public bool IsOccupied { get; private set; }
    public GameObject StoredItem => slotItemObject;

    public void SetupSlotItem(Sprite _slotImage, GameObject _slotObject, string _itemName)
    {
        slotItemImage.sprite = _slotImage;
        slotItemObject = _slotObject;
        slotItemName.text = _itemName;
    }

    public void ClearSlot()
    {
        slotItemImage.sprite = null;
        slotItemObject = null;
        slotItemName.text = "";

        IsOccupied = false;
    }
}
