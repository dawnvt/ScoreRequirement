﻿using System;
using SiraUtil.Tools;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.GameplaySetup;
using IPA.Config.Data;
using ScoreRequirement.Configuration;
using ScoreRequirement.Managers;
using Zenject;

namespace ScoreRequirement.UI
{
    public class SRSettingsViewController : IInitializable, IDisposable
    {
        private PluginConfig _config;
        
        public SRSettingsViewController(PluginConfig config)
        {
            _config = config;
        }

        public void Initialize()
        {
            GameplaySetup.instance.AddTab("ScoreRequirement", "ScoreRequirement.UI.SRSettingsView.bsml", this);
        }

        public void Dispose()
        {
            GameplaySetup.instance.RemoveTab("ScoreRequirement");
        }

        [UIValue("srEnabled")]
        private bool SREnabled
        {
            get => _config.isSREnabled;
            set => _config.isSREnabled = value;
        }
        
        [UIValue("comboRequirement")]
        private bool ComboReqEnabled
        {
            get => _config.isComboRequirementEnabled;
            set => _config.isComboRequirementEnabled = value;
        }
        
        [UIValue("breakLimit")]
        private bool BreakLimitEnabled
        {
            get => _config.isComboBreakLimitEnabled;
            set => _config.isComboBreakLimitEnabled = value;
        }
        
        [UIValue("accRequirement")]
        private bool AccReqEnabled
        {
            get => _config.isAccRequirementEnabled;
            set => _config.isAccRequirementEnabled = value;
        }
        
        [UIValue("pauseLimit")]
        private bool PauseLimitEnabled
        {
            get => _config.isPauseLimitEnabled;
            set => _config.isPauseLimitEnabled = value;
        }
        
        [UIValue("missCount")]
        private bool MissCountEnabled
        {
            get => _config.isMissLimitEnabled;
            set => _config.isMissLimitEnabled = value;
        }
        
        [UIValue("comboRequirementSlider")]
        private int ComboRequirement
        {
            get => _config.minimumComboCount;
            set => _config.minimumComboCount = value;
        }
        
        [UIValue("comboBreakLimitSlider")]
        private int ComboBreakLimit
        {
            get => _config.comboBreakLimit;
            set => _config.comboBreakLimit = value;
        }
        
        [UIValue("accRequirementSlider")]
        private float AccRequirement
        {
            get => _config.accRequirement;
            set => _config.accRequirement = value;
        }
        
        [UIValue("pauseLimitSlider")]
        private int PauseLimit
        {
            get => _config.pauseLimit;
            set => _config.pauseLimit = value;
        }
        
        [UIValue("maxMissCountSlider")]
        private int MaxMissCount
        {
            get => _config.missLimit;
            set => _config.missLimit = value;
        }
    }
}
