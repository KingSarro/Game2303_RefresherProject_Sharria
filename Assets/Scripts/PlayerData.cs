using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour{
    [SerializeField] private PlayerStats health;
    [SerializeField] private Image statBar;


    private void Start(){
        health.setMaxStat(50);
        health.setCurrentStat(health.getMaxStat());
    }
    private void Update(){
        statBar.fillAmount = health.getCurrentStat() / health.getMaxStat();
    }

    public void SetHealth(int damageAmount){
        health.setCurrentStat( Mathf.Clamp( (health.getCurrentStat() - damageAmount) , 0, health.getMaxStat()) );
    }
}
