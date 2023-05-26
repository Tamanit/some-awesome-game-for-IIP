using System.Security.AccessControl;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class ChangeTools : MonoBehaviour
{
    private Animator _animator;
    private AnimatorController _fireController;
    private AnimatorController _plumpController;
    private AudioSource audio;
    void Awake()
    {
        _fireController = Resources.Load<AnimatorController>("Player/crow_box_idle");
        _plumpController = Resources.Load<AnimatorController>("Player/crow_ac");
        _animator = gameObject.GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        _animator.SetBool("PickingUp", Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Alpha2));

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gameObject.tag = "Plumper";
            _animator.runtimeAnimatorController = _plumpController;
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gameObject.tag = "Fireman";
            _animator.runtimeAnimatorController = _fireController;
        }
        
        _animator.SetBool("Attack", Input.GetKey(KeyCode.E));

    }
    public void fireExSound()
    {
        audio.Play();
    }
    
    
}
