using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    [JsiiInterface(nativeType: typeof(IFsxFileCacheDataRepositoryAssociation), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheDataRepositoryAssociation")]
    public interface IFsxFileCacheDataRepositoryAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#data_repository_path FsxFileCache#data_repository_path}.</summary>
        [JsiiProperty(name: "dataRepositoryPath", typeJson: "{\"primitive\":\"string\"}")]
        string DataRepositoryPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#file_cache_path FsxFileCache#file_cache_path}.</summary>
        [JsiiProperty(name: "fileCachePath", typeJson: "{\"primitive\":\"string\"}")]
        string FileCachePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#data_repository_subdirectories FsxFileCache#data_repository_subdirectories}.</summary>
        [JsiiProperty(name: "dataRepositorySubdirectories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DataRepositorySubdirectories
        {
            get
            {
                return null;
            }
        }

        /// <summary>nfs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#nfs FsxFileCache#nfs}
        /// </remarks>
        [JsiiProperty(name: "nfs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxFileCache.FsxFileCacheDataRepositoryAssociationNfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nfs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#tags FsxFileCache#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxFileCacheDataRepositoryAssociation), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheDataRepositoryAssociation")]
        internal sealed class _Proxy : DeputyBase, aws.FsxFileCache.IFsxFileCacheDataRepositoryAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#data_repository_path FsxFileCache#data_repository_path}.</summary>
            [JsiiProperty(name: "dataRepositoryPath", typeJson: "{\"primitive\":\"string\"}")]
            public string DataRepositoryPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#file_cache_path FsxFileCache#file_cache_path}.</summary>
            [JsiiProperty(name: "fileCachePath", typeJson: "{\"primitive\":\"string\"}")]
            public string FileCachePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#data_repository_subdirectories FsxFileCache#data_repository_subdirectories}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataRepositorySubdirectories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DataRepositorySubdirectories
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>nfs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#nfs FsxFileCache#nfs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nfs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxFileCache.FsxFileCacheDataRepositoryAssociationNfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Nfs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#tags FsxFileCache#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
