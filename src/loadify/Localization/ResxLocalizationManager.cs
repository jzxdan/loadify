﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Infralution.Localization.Wpf;

namespace loadify.Localization
{
    public class ResxLocalizationManager : ILocalizationManager
    {
        /// <summary> 
        /// Sets the specified language for the current thread and enables the dynamic Resx extension to transform all bindings to the new language 
        /// </summary>
        /// <param name="language"> The new language to set </param>
        public void SetLanguage(Language language)
        {
            try
            {
                // Setting the culture for ui and common text output
                CultureInfo.DefaultThreadCurrentCulture = language.Culture;
                CultureInfo.DefaultThreadCurrentUICulture = language.Culture;
                Thread.CurrentThread.CurrentCulture = language.Culture;
                Thread.CurrentThread.CurrentUICulture = language.Culture;
                CultureManager.UICulture = language.Culture; // update bindings
            }
            catch (CultureNotFoundException)
            {
                // set the language to english if the specified language was not found
                SetLanguage(Language.English);
            }
        }

        public IEnumerable<Language> GetSupportedLanguages()
        {
            var results = new List<Language>();

            foreach (var dir in Directory.GetDirectories(System.Windows.Forms.Application.StartupPath))
            {
                try
                {
                    //see if this directory corresponds to a valid culture name
                    var dirInfo = new DirectoryInfo(dir);
                    var culture = CultureInfo.GetCultureInfo(dirInfo.Name);

                    //determine if a resources DLL exists in this directory that
                    //matches the executable name
                    if (dirInfo.GetFiles(Path.GetFileNameWithoutExtension
                        (System.Windows.Forms.Application.ExecutablePath) + ".resources.dll").Length > 0)
                    {
                        results.Add(new Language(culture));
                    }
                }
                catch { } //ignore any ArgumentExceptions generated for non-culture directories
            }

            return results;
        }
    }
}
