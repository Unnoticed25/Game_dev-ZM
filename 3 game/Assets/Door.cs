using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool _isOpened;
    [SerializeField] private Animator _animator;


    public void Open() {
        _animator.SetBool("IsOpened", _isOpened);
        _isOpened = !_isOpened;
    }   
}
