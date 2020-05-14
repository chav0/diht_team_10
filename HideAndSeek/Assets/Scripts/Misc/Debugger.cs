﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger {  // for logcat debugging
    private static string DEBUG_PREFIX = "HAS# ";

    public static void Log(string message) {
        Debug.Log(DEBUG_PREFIX + message);
    }
}