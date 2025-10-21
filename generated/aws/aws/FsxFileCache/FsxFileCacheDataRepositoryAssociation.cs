using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxFileCache.FsxFileCacheDataRepositoryAssociation")]
    public class FsxFileCacheDataRepositoryAssociation : aws.FsxFileCache.IFsxFileCacheDataRepositoryAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#data_repository_path FsxFileCache#data_repository_path}.</summary>
        [JsiiProperty(name: "dataRepositoryPath", typeJson: "{\"primitive\":\"string\"}")]
        public string DataRepositoryPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#file_cache_path FsxFileCache#file_cache_path}.</summary>
        [JsiiProperty(name: "fileCachePath", typeJson: "{\"primitive\":\"string\"}")]
        public string FileCachePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#data_repository_subdirectories FsxFileCache#data_repository_subdirectories}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataRepositorySubdirectories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DataRepositorySubdirectories
        {
            get;
            set;
        }

        private object? _nfs;

        /// <summary>nfs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#nfs FsxFileCache#nfs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nfs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsxFileCache.FsxFileCacheDataRepositoryAssociationNfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Nfs
        {
            get => _nfs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FsxFileCache.IFsxFileCacheDataRepositoryAssociationNfs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FsxFileCache.IFsxFileCacheDataRepositoryAssociationNfs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _nfs = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#tags FsxFileCache#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
