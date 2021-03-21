using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using TeamManager.Entities;

namespace TeamManager.Helpers
{
    public static class FileHelper
    {
        public static JsonSerializer Serializer { get; set; }

        static FileHelper()
        {
            Serializer = new JsonSerializer();
        }

        public static void WriteToJson(string fileName, Tactic tactic)
        {
            using (var fs = new FileStream(fileName, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        jw.Formatting = Formatting.Indented;

                        Serializer.Serialize(jw, tactic);
                    }
                }
            }
        }

        public static Tactic ReadFromJson(string fileName)
        {
            Tactic tactic = null;

            try
            {
                using (var fs = new FileStream(fileName, FileMode.Open))
                {
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        using (var jr = new JsonTextReader(sr))
                        {
                            tactic = Serializer.Deserialize<Tactic>(jr);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show($"There is no file associated this name: {fileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tactic;
        }
    }
}