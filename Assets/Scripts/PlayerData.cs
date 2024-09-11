using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour{
    [SerializeField] PlayerStats health;
    [SerializeField] private Image statBar;

    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;

    private void Start(){
        maxHealth = health.getMaxStat();
        currentHealth = maxHealth;
    }
    private void Update(){
        statBar.fillAmount = currentHealth / maxHealth;
    }

    public void SetHealth(int damageAmount){
        currentHealth = Mathf.Clamp( (currentHealth - damageAmount) , 0, maxHealth);
    }
}
