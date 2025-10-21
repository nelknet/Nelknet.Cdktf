using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2NetworkInsightsPath
{
    [JsiiInterface(nativeType: typeof(IEc2NetworkInsightsPathFilterAtDestination), fullyQualifiedName: "aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestination")]
    public interface IEc2NetworkInsightsPathFilterAtDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_address Ec2NetworkInsightsPath#destination_address}.</summary>
        [JsiiProperty(name: "destinationAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_port_range Ec2NetworkInsightsPath#destination_port_range}
        /// </remarks>
        [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationDestinationPortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationDestinationPortRange? DestinationPortRange
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source_address Ec2NetworkInsightsPath#source_address}.</summary>
        [JsiiProperty(name: "sourceAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SourceAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source_port_range Ec2NetworkInsightsPath#source_port_range}
        /// </remarks>
        [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationSourcePortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationSourcePortRange? SourcePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2NetworkInsightsPathFilterAtDestination), fullyQualifiedName: "aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestination")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_address Ec2NetworkInsightsPath#destination_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>destination_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#destination_port_range Ec2NetworkInsightsPath#destination_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationDestinationPortRange\"}", isOptional: true)]
            public aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationDestinationPortRange? DestinationPortRange
            {
                get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationDestinationPortRange?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source_address Ec2NetworkInsightsPath#source_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sourceAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SourceAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>source_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_network_insights_path#source_port_range Ec2NetworkInsightsPath#source_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourcePortRange", typeJson: "{\"fqn\":\"aws.ec2NetworkInsightsPath.Ec2NetworkInsightsPathFilterAtDestinationSourcePortRange\"}", isOptional: true)]
            public aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationSourcePortRange? SourcePortRange
            {
                get => GetInstanceProperty<aws.Ec2NetworkInsightsPath.IEc2NetworkInsightsPathFilterAtDestinationSourcePortRange?>();
            }
        }
    }
}
