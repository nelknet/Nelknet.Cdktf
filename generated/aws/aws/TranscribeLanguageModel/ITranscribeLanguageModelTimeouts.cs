using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TranscribeLanguageModel
{
    [JsiiInterface(nativeType: typeof(ITranscribeLanguageModelTimeouts), fullyQualifiedName: "aws.transcribeLanguageModel.TranscribeLanguageModelTimeouts")]
    public interface ITranscribeLanguageModelTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#create TranscribeLanguageModel#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITranscribeLanguageModelTimeouts), fullyQualifiedName: "aws.transcribeLanguageModel.TranscribeLanguageModelTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.TranscribeLanguageModel.ITranscribeLanguageModelTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transcribe_language_model#create TranscribeLanguageModel#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
