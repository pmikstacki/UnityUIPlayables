using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.GraphicAnimation;
using Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.Shared;
using UnityEngine.UI;

namespace Flex.Scripts.FlexUI.PlayableTimeline.Assets.UnityUIPlayables.Runtime.RawImageAnimation
{
    public class RawImageAnimationMixer : AnimationMixer<RawImage, RawImageAnimationBehaviour>
    {
        private readonly GraphicColorMixer _colorMixer = new GraphicColorMixer();
        private readonly RawImageUVRectMixer _uvRectMixer = new RawImageUVRectMixer();

        public override void SetupFrame(RawImage binding)
        {
            base.SetupFrame(binding);
            _colorMixer.SetupFrame();
            _uvRectMixer.SetupFrame();
        }

        public override void Blend(RawImageAnimationBehaviour behaviour, float inputWeight, float progress)
        {
            if (behaviour.ControlColor)
            {
                _colorMixer.Blend(behaviour.StartValue.Color, behaviour.EndValue.Color, inputWeight, progress);
            }

            if (behaviour.ControlUvRect)
            {
                _uvRectMixer.Blend(behaviour.StartValue.UvRect, behaviour.EndValue.UvRect, inputWeight, progress);
            }
        }

        public override void ApplyFrame()
        {
            _colorMixer.ApplyFrame(Binding);
            _uvRectMixer.ApplyFrame(Binding);
        }
    }
}