using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksNodeGroup
{
    [JsiiInterface(nativeType: typeof(IEksNodeGroupUpdateConfig), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupUpdateConfig")]
    public interface IEksNodeGroupUpdateConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#max_unavailable EksNodeGroup#max_unavailable}.</summary>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnavailable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#max_unavailable_percentage EksNodeGroup#max_unavailable_percentage}.</summary>
        [JsiiProperty(name: "maxUnavailablePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUnavailablePercentage
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksNodeGroupUpdateConfig), fullyQualifiedName: "aws.eksNodeGroup.EksNodeGroupUpdateConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksNodeGroup.IEksNodeGroupUpdateConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#max_unavailable EksNodeGroup#max_unavailable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnavailable
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_node_group#max_unavailable_percentage EksNodeGroup#max_unavailable_percentage}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUnavailablePercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUnavailablePercentage
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
