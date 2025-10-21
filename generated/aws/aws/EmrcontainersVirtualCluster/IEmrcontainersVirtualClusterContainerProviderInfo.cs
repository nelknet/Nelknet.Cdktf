using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersVirtualCluster
{
    [JsiiInterface(nativeType: typeof(IEmrcontainersVirtualClusterContainerProviderInfo), fullyQualifiedName: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfo")]
    public interface IEmrcontainersVirtualClusterContainerProviderInfo
    {
        /// <summary>eks_info block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#eks_info EmrcontainersVirtualCluster#eks_info}
        /// </remarks>
        [JsiiProperty(name: "eksInfo", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfo\"}")]
        aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo EksInfo
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEmrcontainersVirtualClusterContainerProviderInfo), fullyQualifiedName: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfo")]
        internal sealed class _Proxy : DeputyBase, aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>eks_info block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#eks_info EmrcontainersVirtualCluster#eks_info}
            /// </remarks>
            [JsiiProperty(name: "eksInfo", typeJson: "{\"fqn\":\"aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterContainerProviderInfoEksInfo\"}")]
            public aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo EksInfo
            {
                get => GetInstanceProperty<aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterContainerProviderInfoEksInfo>()!;
            }
        }
    }
}
