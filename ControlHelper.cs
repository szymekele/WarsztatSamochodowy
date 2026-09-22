using System;
using System.Reflection;
using System.Windows.Forms;

namespace WarsztatSamochodowy
{
    public static class ControlHelper
    {
        /// <summary>
        /// Włącza DoubleBuffered na kontrolce (np. DataGridView, Panel) za pomocą refleksji,
        /// co eliminuje migotanie (flickering) przy przewijaniu i odświeżaniu danych.
        /// </summary>
        public static void EnableDoubleBuffering(this Control control)
        {
            if (control == null)
                return;

            try
            {
                PropertyInfo doubleBufferedProp = typeof(Control).GetProperty(
                    "DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance
                );

                if (doubleBufferedProp != null)
                {
                    doubleBufferedProp.SetValue(control, true, null);
                }
            }
            catch
            {
                // Bezpieczny fallback - jeśli środowisko zabrania refleksji, kontynuuj
            }
        }
    }
}
