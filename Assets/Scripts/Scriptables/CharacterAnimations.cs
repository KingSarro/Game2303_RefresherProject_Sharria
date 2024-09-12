using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterAnimations", menuName = "ScriptableObjects/Player/CharacterAnimationList")]
public class CharacterAnimations : ScriptableObject{
    [SerializeField] private AnimationClip idle;
    [SerializeField] private AnimationClip walk;
    [SerializeField] private AnimationClip run;
    [SerializeField] private AnimationClip fall;
    [SerializeField] private AnimationClip jump;
    


    public AnimationClip getIdleAnimation(){
        return idle;
    }
    public AnimationClip getWalkAnimation(){
        return walk;
    }
    public AnimationClip getRunAnimation(){
        return run;
    }
    public AnimationClip getFallAnimation(){
        return fall;
    }
    public AnimationClip getJumpAnimation(){
        return jump;
    }

    public void SetIdleAnimation(AnimationClip animation){
        idle = animation;
    }
    public void SetWalkAnimation(AnimationClip animation){
        walk = animation;
    }
    public void SetRunAnimation(AnimationClip animation){
        run = animation;
    }
    public void SetFallAnimation(AnimationClip animation){
        fall = animation;
    }
    public void SetJumpAnimation(AnimationClip animation){
        jump = animation;
    }

    
}
