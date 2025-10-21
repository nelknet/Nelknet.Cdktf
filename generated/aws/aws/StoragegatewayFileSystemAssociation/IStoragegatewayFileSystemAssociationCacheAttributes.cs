using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewayFileSystemAssociation
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayFileSystemAssociationCacheAttributes), fullyQualifiedName: "aws.storagegatewayFileSystemAssociation.StoragegatewayFileSystemAssociationCacheAttributes")]
    public interface IStoragegatewayFileSystemAssociationCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#cache_stale_timeout_in_seconds StoragegatewayFileSystemAssociation#cache_stale_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CacheStaleTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayFileSystemAssociationCacheAttributes), fullyQualifiedName: "aws.storagegatewayFileSystemAssociation.StoragegatewayFileSystemAssociationCacheAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.StoragegatewayFileSystemAssociation.IStoragegatewayFileSystemAssociationCacheAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#cache_stale_timeout_in_seconds StoragegatewayFileSystemAssociation#cache_stale_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CacheStaleTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
