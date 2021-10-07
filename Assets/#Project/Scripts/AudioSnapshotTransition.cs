using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSnapshotTransition : MonoBehaviour
{
    public AudioMixerSnapshot snapshot;
    public float transitionTime; // temps de transition à définir (2 = super rapide / 10 = lent)

    private void OnMouseDown()  // ce qui est présent dans cette méthode peut être utilisé aussi dans un trigger ou if 
    { 
        snapshot.TransitionTo(transitionTime); 
    }
}
