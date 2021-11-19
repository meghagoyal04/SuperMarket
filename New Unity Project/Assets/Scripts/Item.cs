using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
	[SerializeField] public string itemName;    // Name of the item
	[SerializeField] public Sprite itemSprite;
	[SerializeField] public int itemPrice;
	[SerializeField] public int calcium;
	[SerializeField] public int carbohydrates;
	[SerializeField] public int iron;
	[SerializeField] public int protien;
	[SerializeField] public int vitamin_a;
	[SerializeField] public int vitamin_c;
	[SerializeField] public int calories;
}

