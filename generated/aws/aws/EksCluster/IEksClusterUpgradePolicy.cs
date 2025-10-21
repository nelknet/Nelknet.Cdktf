using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterUpgradePolicy), fullyQualifiedName: "aws.eksCluster.EksClusterUpgradePolicy")]
    public interface IEksClusterUpgradePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#support_type EksCluster#support_type}.</summary>
        [JsiiProperty(name: "supportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SupportType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterUpgradePolicy), fullyQualifiedName: "aws.eksCluster.EksClusterUpgradePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterUpgradePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#support_type EksCluster#support_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SupportType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
