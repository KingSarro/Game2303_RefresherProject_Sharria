using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/Player/DepletableStat")]
public class PlayerStats : ScriptableObject{
    [SerializeField] private int maxStat;
    [SerializeField] private int currentStat;
    


    public int getMaxStat(){
        return maxStat;
    }
    public int getCurrentStat(){
        return currentStat;
    }

    
}
