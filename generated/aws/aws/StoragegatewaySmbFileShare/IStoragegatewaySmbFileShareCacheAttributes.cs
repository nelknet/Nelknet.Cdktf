using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewaySmbFileShare
{
    [JsiiInterface(nativeType: typeof(IStoragegatewaySmbFileShareCacheAttributes), fullyQualifiedName: "aws.storagegatewaySmbFileShare.StoragegatewaySmbFileShareCacheAttributes")]
    public interface IStoragegatewaySmbFileShareCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#cache_stale_timeout_in_seconds StoragegatewaySmbFileShare#cache_stale_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CacheStaleTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewaySmbFileShareCacheAttributes), fullyQualifiedName: "aws.storagegatewaySmbFileShare.StoragegatewaySmbFileShareCacheAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.StoragegatewaySmbFileShare.IStoragegatewaySmbFileShareCacheAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#cache_stale_timeout_in_seconds StoragegatewaySmbFileShare#cache_stale_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CacheStaleTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
