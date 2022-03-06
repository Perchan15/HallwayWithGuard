using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesOnDestroy : MonoBehaviour
{

    public ParticleSystem poofParticles;

    public void SpawnParticles(Vector3 position)
    {
        Instantiate(poofParticles, position, Quaternion.identity);
    }
}
