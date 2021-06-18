using System;

namespace KevinCastejon.UnityTools
{
    [Serializable]
    public class AnimationInfo
    {
        public string name;
        public int length;
        public bool loop;
        public bool autoFramerate;
        public int framerate;

        public AnimationInfo()
        {
            name = "AnimationClipName";
            length = 1;
            loop = true;
            autoFramerate = true;
            framerate = 60;
        }
    }
}