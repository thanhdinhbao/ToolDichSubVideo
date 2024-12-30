using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolDichSubVideo
{
    public  class GeminiPrompt
    {
        public class Content
        {
            public List<Part> parts { get; set; }
        }

        public class Part
        {
            public string text { get; set; }
        }

        public class Root
        {
            public List<Content> contents { get; set; }
        }
    }
}
