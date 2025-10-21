using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    [JsiiInterface(nativeType: typeof(IFsxFileCacheLustreConfigurationMetadataConfiguration), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheLustreConfigurationMetadataConfiguration")]
    public interface IFsxFileCacheLustreConfigurationMetadataConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#storage_capacity FsxFileCache#storage_capacity}.</summary>
        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double StorageCapacity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxFileCacheLustreConfigurationMetadataConfiguration), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheLustreConfigurationMetadataConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FsxFileCache.IFsxFileCacheLustreConfigurationMetadataConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#storage_capacity FsxFileCache#storage_capacity}.</summary>
            [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageCapacity
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
