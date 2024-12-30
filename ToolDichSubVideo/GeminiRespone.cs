using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolDichSubVideo
{
    public class GeminiRespone
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Candidate
        {
            public Content content { get; set; }
            public string finishReason { get; set; }
            public double avgLogprobs { get; set; }
        }

        public class Content
        {
            public List<Part> parts { get; set; }
            public string role { get; set; }
        }

        public class Part
        {
            public string text { get; set; }
        }

        public class Root
        {
            public List<Candidate> candidates { get; set; }
            public UsageMetadata usageMetadata { get; set; }
            public string modelVersion { get; set; }
        }

        public class UsageMetadata
        {
            public int promptTokenCount { get; set; }
            public int candidatesTokenCount { get; set; }
            public int totalTokenCount { get; set; }
        }


    }
}
