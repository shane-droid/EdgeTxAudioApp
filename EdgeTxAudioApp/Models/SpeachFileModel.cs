using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdgeTxAudioApp.Models
{
    public class SpeachFileModel
    {
        public string Id { get; set; }
        public string SourceText { get; set; }
        public string Translation { get; set; }
        public string Context { get; set; }
        public string Path { get; set; }
        public string Filename { get; set; }

        //public SpeachFileModel(string id, string sourceText, string translation, string context, string path, string filename)
        //{
        //    Id = id;
        //    SourceText = sourceText;
        //    Translation = translation;
        //    Context = context;
        //    Path = path;
        //    Filename = filename;
        //}
    }
}
