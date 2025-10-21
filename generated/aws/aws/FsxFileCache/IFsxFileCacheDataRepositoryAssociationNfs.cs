using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    [JsiiInterface(nativeType: typeof(IFsxFileCacheDataRepositoryAssociationNfs), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheDataRepositoryAssociationNfs")]
    public interface IFsxFileCacheDataRepositoryAssociationNfs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#version FsxFileCache#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#dns_ips FsxFileCache#dns_ips}.</summary>
        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsIps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxFileCacheDataRepositoryAssociationNfs), fullyQualifiedName: "aws.fsxFileCache.FsxFileCacheDataRepositoryAssociationNfs")]
        internal sealed class _Proxy : DeputyBase, aws.FsxFileCache.IFsxFileCacheDataRepositoryAssociationNfs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#version FsxFileCache#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#dns_ips FsxFileCache#dns_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsIps
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
