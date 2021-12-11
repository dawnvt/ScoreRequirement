﻿using IPA.Loader;
using IPA.Logging;
using ScoreRequirement.Configuration;
using Zenject;
using SiraUtil;
using ScoreRequirement.UI;
using SiraUtil.Zenject;

namespace ScoreRequirement.Installers
{
    internal class SRMenuInstaller : Installer
    {
        private readonly Logger _logger;
        private readonly PluginConfig _config;
        private readonly UBinder<Plugin, PluginMetadata> _metadata;

        internal SRMenuInstaller(Logger logger, PluginConfig config, UBinder<Plugin, PluginMetadata> metadata)
        {
            _logger = logger;
            _config = config;
            _metadata = metadata;
        }
        
        public override void InstallBindings()
            {
                Container.BindInterfacesAndSelfTo<SRSettingsViewController>().AsSingle();
                Container.BindInstance(_metadata).AsSingle();
                Container.BindInstance(_logger).AsSingle();
                Container.BindInstance(_config).AsSingle();
            }
        }
    }
