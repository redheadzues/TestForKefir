﻿using Assets.Source.CodeBase.Infrustructure.Services;
using UnityEngine;

namespace Assets.Source.CodeBase.Infrustructure.DataProviders
{
    public class AssetProvider : IAssetProvider
    {
        public GameObject Instantiate(string path) =>
            Object.Instantiate(Resources.Load<GameObject>(path));

        public GameObject Instantiate(string path, Transform parent) =>
            Object.Instantiate(Resources.Load<GameObject>(path), parent);
    }
}
