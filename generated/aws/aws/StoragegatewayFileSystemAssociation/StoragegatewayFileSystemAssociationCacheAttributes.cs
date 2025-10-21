using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewayFileSystemAssociation
{
    [JsiiByValue(fqn: "aws.storagegatewayFileSystemAssociation.StoragegatewayFileSystemAssociationCacheAttributes")]
    public class StoragegatewayFileSystemAssociationCacheAttributes : aws.StoragegatewayFileSystemAssociation.IStoragegatewayFileSystemAssociationCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_file_system_association#cache_stale_timeout_in_seconds StoragegatewayFileSystemAssociation#cache_stale_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CacheStaleTimeoutInSeconds
        {
            get;
            set;
        }
    }
}
