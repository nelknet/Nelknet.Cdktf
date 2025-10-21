using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxFileCache.FsxFileCacheLustreConfigurationMetadataConfiguration")]
    public class FsxFileCacheLustreConfigurationMetadataConfiguration : aws.FsxFileCache.IFsxFileCacheLustreConfigurationMetadataConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#storage_capacity FsxFileCache#storage_capacity}.</summary>
        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double StorageCapacity
        {
            get;
            set;
        }
    }
}
