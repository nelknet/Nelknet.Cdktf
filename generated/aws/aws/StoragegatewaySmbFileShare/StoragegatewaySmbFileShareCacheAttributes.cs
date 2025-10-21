using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewaySmbFileShare
{
    [JsiiByValue(fqn: "aws.storagegatewaySmbFileShare.StoragegatewaySmbFileShareCacheAttributes")]
    public class StoragegatewaySmbFileShareCacheAttributes : aws.StoragegatewaySmbFileShare.IStoragegatewaySmbFileShareCacheAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_smb_file_share#cache_stale_timeout_in_seconds StoragegatewaySmbFileShare#cache_stale_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheStaleTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CacheStaleTimeoutInSeconds
        {
            get;
            set;
        }
    }
}
