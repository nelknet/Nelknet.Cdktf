using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockProvisionedModelThroughput
{
    [JsiiByValue(fqn: "aws.bedrockProvisionedModelThroughput.BedrockProvisionedModelThroughputTimeouts")]
    public class BedrockProvisionedModelThroughputTimeouts : aws.BedrockProvisionedModelThroughput.IBedrockProvisionedModelThroughputTimeouts
    {
        /// <summary>A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as "30s" or "2h45m". Valid time units are "s" (seconds), "m" (minutes), "h" (hours).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput#create BedrockProvisionedModelThroughput#create}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
