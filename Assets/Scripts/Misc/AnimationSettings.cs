using UnityEngine;

namespace Misc
{
    [ExecuteInEditMode]
    public class AnimationSettings : MonoBehaviour
    {
        [SerializeField] private Animator _animator;
        [SerializeField] private CharacterPose _characterPose;

        private enum CharacterPose
        {
            SlashAnticipation, SlashAction,
            SpellAnticipation, SpellAction,
            SummonAnticipation, SummonAction
        }
        
        private void OnValidate()
        {
            SetCharacterPose();
        }

        private void SetCharacterPose()
        {
            switch (_characterPose)
            {
                case CharacterPose.SlashAnticipation:
                    UpdateAnimator("SlashOverhead", 0, 0.22f);
                    break;
                case CharacterPose.SlashAction:
                    UpdateAnimator("SlashOverhead", 0, 0.5f);
                    break;
                case CharacterPose.SpellAnticipation:
                    UpdateAnimator("CastForwardIn", 0, 1.0f);
                    break;
                case CharacterPose.SpellAction:
                    UpdateAnimator("CastForward", 0, 0.2f);
                    break;
                case CharacterPose.SummonAnticipation:
                    UpdateAnimator("SummonIn", 0, 1.0f);
                    break;
                case CharacterPose.SummonAction:
                    UpdateAnimator("SummonCast", 0, 0.5f);
                    break;
            }
        }

        private void UpdateAnimator(string anim, int layer, float value)
        {
            _animator.Play(anim, layer, value);
            _animator.Update(0);
        }
    }
}
