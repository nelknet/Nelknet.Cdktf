using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterOutpostConfigControlPlanePlacement), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement")]
    public interface IEksClusterOutpostConfigControlPlanePlacement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#group_name EksCluster#group_name}.</summary>
        [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
        string GroupName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterOutpostConfigControlPlanePlacement), fullyQualifiedName: "aws.eksCluster.EksClusterOutpostConfigControlPlanePlacement")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterOutpostConfigControlPlanePlacement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#group_name EksCluster#group_name}.</summary>
            [JsiiProperty(name: "groupName", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
