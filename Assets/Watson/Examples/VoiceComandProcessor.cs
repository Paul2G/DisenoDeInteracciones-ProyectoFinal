using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IBM.Watsson.Examples{

    public class VoiceComandProcessor : MonoBehaviour
    {
        static protected VoiceComandProcessor s_VoiceInstance;
        static public VoiceComandProcessor Instance {get {return s_VoiceInstance;}}
        public delegate void OnVoiceComand(string action);
        public OnVoiceComand onVoiceComand;
        public List<string> actions;

        void Awake()
        {
            s_VoiceInstance = this;
        }

        void Start()
        {
            
        }

        public void Create(string transcript)
        {
            string[] words = transcript.Split(' ');
            foreach (string word in words)
            {
                if (actions.Contains(word))
                {
                    if (onVoiceComand != null)
                    {
                        onVoiceComand.Invoke(word);
                    }
                    break;
                }
            }
        
        }

        void Update()
        {
            
        }
    }
}