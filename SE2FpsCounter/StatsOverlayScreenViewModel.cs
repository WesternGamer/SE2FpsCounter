using Keen.VRage.Library.Diagnostics;
using Keen.VRage.UI.Screens;


namespace SE2FpsCounter
{
    internal class StatsOverlayScreenViewModel : ScreenViewModel
    {
        private string _fpsValueText = "FPS: 0";

        public string FpsValueText
        {
            get => _fpsValueText;
            set
            {
                // Must match the property name or it will not work
                this.SetProperty<string>(ref _fpsValueText, value, "FpsValueText");
            }
        }

        public StatsOverlayScreenViewModel()
        {
            base.NeedsGeneralUIInput = false;

        }

        static int test = 0;

        protected override void Update()
        {
            base.Update();

            FpsValueText = $"FPS: {(int)Math.Round(Stats.Storage.FindStat("Performance/Render Frequency/Total/FPS").Value)}";
        }
    }
}
