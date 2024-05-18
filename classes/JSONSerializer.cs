using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace text_editor.classes
{
    public class JSONSerializer
    {
        private const string _jsonPath = "settings.json";
        private Settings? _settings;

        public JSONSerializer() { }

        // checks if json file exists
        public static bool JSONExists() { if (File.Exists(_jsonPath)) return true; return false; }

        // returns _jsonPath
        public string GetJSONPath() => _jsonPath;

        // writes or overwrites json file with autosave setting
        public void CreateJSON(Settings? settings)
        {
            if (settings == null) settings = new Settings();
            File.WriteAllText(_jsonPath, JsonSerializer.Serialize(settings));
            this._settings = settings;
        }

        // returns auto setting from the file
        public Settings? ReadJSON()
        {
            _settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText("settings.json"));

            if (_settings != null) return _settings;
            
            return null;
        }
    }
}
