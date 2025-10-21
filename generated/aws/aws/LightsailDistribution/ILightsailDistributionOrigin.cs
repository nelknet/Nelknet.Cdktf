using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailDistribution
{
    [JsiiInterface(nativeType: typeof(ILightsailDistributionOrigin), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionOrigin")]
    public interface ILightsailDistributionOrigin
    {
        /// <summary>The name of the origin resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#name LightsailDistribution#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The AWS Region name of the origin resource.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#region_name LightsailDistribution#region_name}
        /// </remarks>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        /// <summary>The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#protocol_policy LightsailDistribution#protocol_policy}
        /// </remarks>
        [JsiiProperty(name: "protocolPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProtocolPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailDistributionOrigin), fullyQualifiedName: "aws.lightsailDistribution.LightsailDistributionOrigin")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailDistribution.ILightsailDistributionOrigin
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the origin resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#name LightsailDistribution#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The AWS Region name of the origin resource.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#region_name LightsailDistribution#region_name}
            /// </remarks>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The protocol that your Amazon Lightsail distribution uses when establishing a connection with your origin to pull content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_distribution#protocol_policy LightsailDistribution#protocol_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "protocolPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProtocolPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
