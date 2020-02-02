using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrenchMageInventory : MonoBehaviour
{
    private static WrenchMageInventory INSTANCE;

    public static WrenchMageInventory GetInstance() {
        return INSTANCE;
    }

    private void Awake() {
        if(INSTANCE != null) {
            Destroy(this);
        } else {
            INSTANCE = this;
        }
    }

    private List<SpawnablePlatform> inventory = new List<SpawnablePlatform>();
    private int currentViewingIndex = -1;

    public void addItem(SpawnablePlatform platform) {
        inventory.Add(platform);
        currentViewingIndex = inventory.Count - 1;
    }

    public SpawnablePlatform GetSpawnablePlatform() {
        if(currentViewingIndex == -1) {
            return null;
        }
        SpawnablePlatform result = inventory[currentViewingIndex];
        inventory.RemoveAt(currentViewingIndex);
        currentViewingIndex--;
        return result;
    }

    public SpawnablePlatform previewSpawnablePlatform() {
        if (currentViewingIndex == -1) {
            return null;
        }
        return inventory[currentViewingIndex];
    }
    
    public void moveCursorLeft() {
        switch(currentViewingIndex) {
            case 0: if(inventory.Count > 0) {
                    currentViewingIndex = inventory.Count - 1;
                } else {
                    currentViewingIndex = -1;
                }
                break;
            case -1:
                // Do Nothing
                break;
            default:
                currentViewingIndex--;
                break;
        }
    }

    public void moveCursorRight() {
        if (currentViewingIndex != -1) {
            currentViewingIndex++;
            currentViewingIndex = currentViewingIndex % inventory.Count;
        }
    }

    public void resetInventory() {
        inventory.Clear();
        currentViewingIndex = -1;
    }
}
