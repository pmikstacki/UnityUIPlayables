using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.SliderAnimation
{
    public class SliderAnimationMixer : AnimationMixer<Slider, SliderAnimationBehaviour>
    {
        private readonly SliderValueMixer _valueMixer = new SliderValueMixer();

        public override void SetupFrame(Slider binding)
        {
            base.SetupFrame(binding);
            _valueMixer.SetupFrame();
        }

        public override void Blend(SliderAnimationBehaviour behaviour, float inputWeight, float progress)
        {
            _valueMixer.Blend(behaviour.StartValue.Value, behaviour.EndValue.Value, inputWeight, progress);
        }

        public override void ApplyFrame()
        {
            _valueMixer.ApplyFrame(Binding);
        }
    }
}