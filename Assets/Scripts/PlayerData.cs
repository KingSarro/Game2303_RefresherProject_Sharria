using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour{
    [SerializeField] PlayerStats health;

    private int maxHealth;
    private int currentHealth;

    private void Start(){
        maxHealth = health.getMaxStat();
        currentHealth = maxHealth;
    }
    private void Update(){
        health.getStatBar().fillAmount = currentHealth / maxHealth;
    }

    private void setHealth(int damageAmount){
        currentHealth = Mathf.Clamp( (currentHealth - damageAmount) , 0, maxHealth);
    }
}
