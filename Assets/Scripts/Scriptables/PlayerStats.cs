using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/Player/DepletableStat")]
public class PlayerStats : ScriptableObject{
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;


    public int getMaxHealth(){
        return maxHealth;
    }
    
    public int getCurrentHealth(){
        return currentHealth;
    }
}
