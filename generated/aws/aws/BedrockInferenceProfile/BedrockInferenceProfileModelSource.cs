using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockInferenceProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockInferenceProfile.BedrockInferenceProfileModelSource")]
    public class BedrockInferenceProfileModelSource : aws.BedrockInferenceProfile.IBedrockInferenceProfileModelSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_inference_profile#copy_from BedrockInferenceProfile#copy_from}.</summary>
        [JsiiProperty(name: "copyFrom", typeJson: "{\"primitive\":\"string\"}")]
        public string CopyFrom
        {
            get;
            set;
        }
    }
}
