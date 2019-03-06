﻿using System;

namespace Unity.Labs.SuperScience
{
    /// <summary>
    /// This class contains functionality provided by code in the Editor assembly
    /// </summary>
    public static class EditorDelegates
    {
        public static Func<bool> IsMouseOverExampleWindow { get; set; }

        public static event Action onExampleWindowFocus;
        public static event Action onExampleWindowLostFocus;

        public static void OnExampleWindowFocus()
        {
            if (onExampleWindowFocus != null)
                onExampleWindowFocus();
        }

        public static void OnExampleWindowLostFocus()
        {
            if (onExampleWindowLostFocus != null)
                onExampleWindowLostFocus();
        }
    }
}
