using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TranscribeLanguageModel
{
    [JsiiByValue(fqn: "aws.transcribeLanguageModel.TranscribeLanguageModelTimeouts")]
    public class TranscribeLanguageModelTimeouts : aws.TranscribeLanguageModel.ITranscribeLanguageModelTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#create TranscribeLanguageModel#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
