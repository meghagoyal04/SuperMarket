using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
	[SerializeField] public string itemName;    // Name of the item
	[SerializeField] public Sprite itemSprite;
	[SerializeField] public int itemPrice;
}

