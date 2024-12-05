using UnityEngine;

public class WindowAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private string _showTriggerName = "Show";
    [SerializeField] private string _hideTriggerName = "Hide";

    public void Show()
    {
        _animator.SetTrigger(_showTriggerName);
    }

    public void Hide()
    {
        _animator.SetTrigger(_hideTriggerName);
    }
}
