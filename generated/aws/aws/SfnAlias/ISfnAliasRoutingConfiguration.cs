using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SfnAlias
{
    [JsiiInterface(nativeType: typeof(ISfnAliasRoutingConfiguration), fullyQualifiedName: "aws.sfnAlias.SfnAliasRoutingConfiguration")]
    public interface ISfnAliasRoutingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#state_machine_version_arn SfnAlias#state_machine_version_arn}.</summary>
        [JsiiProperty(name: "stateMachineVersionArn", typeJson: "{\"primitive\":\"string\"}")]
        string StateMachineVersionArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#weight SfnAlias#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISfnAliasRoutingConfiguration), fullyQualifiedName: "aws.sfnAlias.SfnAliasRoutingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SfnAlias.ISfnAliasRoutingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#state_machine_version_arn SfnAlias#state_machine_version_arn}.</summary>
            [JsiiProperty(name: "stateMachineVersionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string StateMachineVersionArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#weight SfnAlias#weight}.</summary>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
