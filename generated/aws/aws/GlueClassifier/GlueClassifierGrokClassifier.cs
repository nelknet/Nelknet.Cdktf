using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueClassifier.GlueClassifierGrokClassifier")]
    public class GlueClassifierGrokClassifier : aws.GlueClassifier.IGlueClassifierGrokClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#classification GlueClassifier#classification}.</summary>
        [JsiiProperty(name: "classification", typeJson: "{\"primitive\":\"string\"}")]
        public string Classification
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#grok_pattern GlueClassifier#grok_pattern}.</summary>
        [JsiiProperty(name: "grokPattern", typeJson: "{\"primitive\":\"string\"}")]
        public string GrokPattern
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#custom_patterns GlueClassifier#custom_patterns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customPatterns", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomPatterns
        {
            get;
            set;
        }
    }
}
