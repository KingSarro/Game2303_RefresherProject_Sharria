using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/Player/DepletableStat")]
public class PlayerStats : ScriptableObject{
    [SerializeField] private float maxStat;
    [SerializeField] private float currentStat;
    


    public float getMaxStat(){
        return maxStat;
    }
    public float getCurrentStat(){
        return currentStat;
    }

    public void setMaxStat(float mStat){
        maxStat = mStat;
    }
    public void setCurrentStat(float cStat){
        currentStat = cStat;
    }

    
}
