using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaAlias
{
    [JsiiInterface(nativeType: typeof(ILambdaAliasRoutingConfig), fullyQualifiedName: "aws.lambdaAlias.LambdaAliasRoutingConfig")]
    public interface ILambdaAliasRoutingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#additional_version_weights LambdaAlias#additional_version_weights}.</summary>
        [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeights
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaAliasRoutingConfig), fullyQualifiedName: "aws.lambdaAlias.LambdaAliasRoutingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaAlias.ILambdaAliasRoutingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_alias#additional_version_weights LambdaAlias#additional_version_weights}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "additionalVersionWeights", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, double>? AdditionalVersionWeights
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, double>?>();
            }
        }
    }
}
