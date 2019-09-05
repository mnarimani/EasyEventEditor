#if ODIN_INSPECTOR
using Sirenix.OdinInspector.Editor;
using Sirenix.OdinInspector.Editor.Drawers;
using UnityEngine.Events;

namespace Merlin
{
    public class DisableOdinUnityEventDrawer<T> : OdinValueDrawer<T> where T : UnityEventBase
    {
        protected override void Initialize()
        {
            SkipWhenDrawing = true;

            var drawers = this.Property.GetActiveDrawerChain();

            foreach (var drawer in drawers)
            {
                if (drawer is UnityEventDrawer<T>)
                {
                    drawer.SkipWhenDrawing = true;
                }
            }
        }
    }
} 
#endif