using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Phone,
        Laptop,
        USB,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Phone:    return ItemAsset.Instance.phoneSprite;
            case ItemType.Laptop:   return ItemAsset.Instance.laptopSprite;
            case ItemType.USB:      return ItemAsset.Instance.usbSprite;
        }
    }
}
