﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings {
    public string nickname = "";
    public string hidemanAbility = Constants.AbilitiesTags.Hideman.SURGE;
    public string seekerAbility = Constants.AbilitiesTags.Seeker.FLARE;

    private static Settings _settings;

    private Settings() {}

    public static Settings getInstance() {
        if (_settings == null) {
            _settings = ExtentedPlayerPrefs.GetObject<Settings>(Constants.PlayerPrefs.SETTINGS, new Settings());
        }
        return _settings;
    }

    public static void save() {
        if (_settings != null) {
            ExtentedPlayerPrefs.SetObject<Settings>(Constants.PlayerPrefs.SETTINGS, _settings);
        }
    }
}
