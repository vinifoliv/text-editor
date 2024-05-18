using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace text_editor.classes
{
    //Interface class for serializing into JSON
    public class Settings
    {
        public bool AutoSave {  get; private set; }
        public Font @Font { get; private set; }

        public Settings() 
        {
            AutoSave = false;
            @Font = new Font("Arial", 12, FontStyle.Regular);
        }

        public Settings(bool autoSave, Font font) 
        {
            this.AutoSave = autoSave;
            this.@Font = font;
        }

        public void setAutoSave(bool autoSave) => this.AutoSave = autoSave;

        public void setFont(Font font) => this.Font = font;
    }
}
