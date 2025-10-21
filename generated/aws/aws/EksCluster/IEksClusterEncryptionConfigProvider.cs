using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterEncryptionConfigProvider), fullyQualifiedName: "aws.eksCluster.EksClusterEncryptionConfigProvider")]
    public interface IEksClusterEncryptionConfigProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#key_arn EksCluster#key_arn}.</summary>
        [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
        string KeyArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterEncryptionConfigProvider), fullyQualifiedName: "aws.eksCluster.EksClusterEncryptionConfigProvider")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterEncryptionConfigProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/eks_cluster#key_arn EksCluster#key_arn}.</summary>
            [JsiiProperty(name: "keyArn", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
