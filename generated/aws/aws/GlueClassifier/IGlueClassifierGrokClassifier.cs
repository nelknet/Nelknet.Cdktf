using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    [JsiiInterface(nativeType: typeof(IGlueClassifierGrokClassifier), fullyQualifiedName: "aws.glueClassifier.GlueClassifierGrokClassifier")]
    public interface IGlueClassifierGrokClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#classification GlueClassifier#classification}.</summary>
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        string Classification
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#grok_pattern GlueClassifier#grok_pattern}.</summary>
        [JsiiProperty(name: "grokPattern", typeJson: "{\"primitive\":\"string\"}")]
        string GrokPattern
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#custom_patterns GlueClassifier#custom_patterns}.</summary>
        [JsiiProperty(name: "customPatterns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomPatterns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueClassifierGrokClassifier), fullyQualifiedName: "aws.glueClassifier.GlueClassifierGrokClassifier")]
        internal sealed class _Proxy : DeputyBase, aws.GlueClassifier.IGlueClassifierGrokClassifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#classification GlueClassifier#classification}.</summary>
            [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
            public string Classification
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#grok_pattern GlueClassifier#grok_pattern}.</summary>
            [JsiiProperty(name: "grokPattern", typeJson: "{\"primitive\":\"string\"}")]
            public string GrokPattern
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#custom_patterns GlueClassifier#custom_patterns}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customPatterns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomPatterns
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
