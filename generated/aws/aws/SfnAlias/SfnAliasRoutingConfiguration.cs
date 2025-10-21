using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SfnAlias
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sfnAlias.SfnAliasRoutingConfiguration")]
    public class SfnAliasRoutingConfiguration : aws.SfnAlias.ISfnAliasRoutingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#state_machine_version_arn SfnAlias#state_machine_version_arn}.</summary>
        [JsiiProperty(name: "stateMachineVersionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string StateMachineVersionArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#weight SfnAlias#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }
    }
}
