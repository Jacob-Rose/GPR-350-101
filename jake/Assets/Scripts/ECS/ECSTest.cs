﻿using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class ECSTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EntityManager manager = World.Active.EntityManager;
        Entity entity = manager.CreateEntity(typeof(ParticleComponentData));
        manager.SetComponentData(entity, new ParticleComponentData { });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
