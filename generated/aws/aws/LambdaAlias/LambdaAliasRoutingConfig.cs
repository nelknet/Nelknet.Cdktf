using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaAlias
{
    [JsiiByValue(fqn: "aws.lambdaAlias.LambdaAliasRoutingConfig")]
    public class LambdaAliasRoutingConfig : aws.LambdaAlias.ILambdaAliasRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#additional_version_weights LambdaAlias#additional_version_weights}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeights
        {
            get;
            set;
        }
    }
}
