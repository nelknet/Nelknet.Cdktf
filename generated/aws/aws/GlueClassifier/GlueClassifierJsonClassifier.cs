using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueClassifier
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueClassifier.GlueClassifierJsonClassifier")]
    public class GlueClassifierJsonClassifier : aws.GlueClassifier.IGlueClassifierJsonClassifier
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#json_path GlueClassifier#json_path}.</summary>
        [JsiiProperty(name: "jsonPath", typeJson: "{\"primitive\":\"string\"}")]
        public string JsonPath
        {
            get;
            set;
        }
    }
}
