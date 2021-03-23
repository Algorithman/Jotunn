﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JotunnLib.Entities;

namespace TestMod.Prefabs
{
    public class TestPrefab : PrefabConfig
    {
        public TestPrefab() : base("TestPrefab", "Wood")
        {

        }

        public override void Register()
        {
            // Configure item drop
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            item.m_itemData.m_shared.m_name = "$test_prefab_name";
            item.m_itemData.m_shared.m_description = "$test_prefab_desc";
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_weight = 1f;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_variants = 1;
        }
    }
}
