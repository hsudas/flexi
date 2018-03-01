using Flexi.Shared.Log;
using Microsoft.Win32;
using System;

namespace Flexi.Shared.Helper
{
    public class RegistryHelper
    {
        private static readonly Lazy<RegistryHelper> lazy = new Lazy<RegistryHelper>(() => new RegistryHelper());
        public static RegistryHelper Instance { get { return lazy.Value; } }
        private RegistryHelper()
        {
        }

        public string Read(string path, string key)
        {
            string keyValue = string.Empty;
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                using (var key1 = hklm.OpenSubKey(@"SOFTWARE\" + path))
                {
                    Logger.Info(key1.ToString());
                    keyValue = key1.GetValue(key).ToString();
                }
                //using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + path))
                //{
                //    keyValue = registryKey.GetValue(keyName.ToUpper()).ToString();
                //    if (string.IsNullOrEmpty(keyValue))
                //    {
                //        keyValue = ReadRegistry(path, keyName);
                //    }
                //}
            }
            catch (Exception exc)
            {
                Logger.Error($"RegistryHelper read error! path: {path}, key:{key}", exc);
                keyValue = ReadRegistry(path, key);
            }
            return keyValue;
        }

        //todo:
        public string ReadForWebApi(string path, string key)
        {
            string keyValue = string.Empty;
            keyValue = ReadRegistry(path, key);
            if (string.IsNullOrEmpty(keyValue))
            {
                Logger.Error($"ReadRegistry didn't work! path: {path}, key:{key}");
                try
                {
                    using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                    using (var key1 = hklm.OpenSubKey(@"SOFTWARE\" + path))
                    {
                        keyValue = key1.GetValue(key).ToString();
                    }
                }
                catch (Exception exc3)
                {
                    Logger.Error($"RegistryHelper3 read error! path: {path}, key: {key}", exc3);
                    using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                    using (RegistryKey key1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\" + path, false))
                    {
                        keyValue = key1.GetValue(key).ToString();
                    }
                }
            }
            return keyValue;
        }

        public bool Write(string path, string KeyName, object Value)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\" + path);
                registryKey.SetValue(KeyName.ToUpper(), Value);
                registryKey.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string ReadRegistry(string path, string key, RegistryView registryView = RegistryView.Default)
        {
            string value = string.Empty;
            try
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                using (var key1 = hklm.OpenSubKey(@"SOFTWARE\" + path, false))
                {
                    value = key1.GetValue(key).ToString();
                }
            }
            catch (Exception exc)
            {
                //Logger.Error($"RegistryHelper2 read error! path: {path}, key:{key}, fullpath: {@"SOFTWARE\" + path}", exc);
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, registryView))
                using (var key1 = hklm.OpenSubKey(@"SOFTWARE\" + path, false))
                {
                    value = key1.GetValue(key).ToString();
                }
            }
            return value;
        }
    }
}
