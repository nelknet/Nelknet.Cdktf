using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiInterface(nativeType: typeof(IInstanceInstanceMarketOptions), fullyQualifiedName: "aws.instance.InstanceInstanceMarketOptions")]
    public interface IInstanceInstanceMarketOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#market_type Instance#market_type}.</summary>
        [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MarketType
        {
            get
            {
                return null;
            }
        }

        /// <summary>spot_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#spot_options Instance#spot_options}
        /// </remarks>
        [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.instance.InstanceInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Instance.IInstanceInstanceMarketOptionsSpotOptions? SpotOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceInstanceMarketOptions), fullyQualifiedName: "aws.instance.InstanceInstanceMarketOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Instance.IInstanceInstanceMarketOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#market_type Instance#market_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "marketType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MarketType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>spot_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/instance#spot_options Instance#spot_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spotOptions", typeJson: "{\"fqn\":\"aws.instance.InstanceInstanceMarketOptionsSpotOptions\"}", isOptional: true)]
            public aws.Instance.IInstanceInstanceMarketOptionsSpotOptions? SpotOptions
            {
                get => GetInstanceProperty<aws.Instance.IInstanceInstanceMarketOptionsSpotOptions?>();
            }
        }
    }
}
