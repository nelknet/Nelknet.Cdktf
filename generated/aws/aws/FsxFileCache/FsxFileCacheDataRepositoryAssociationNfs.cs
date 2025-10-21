using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxFileCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsxFileCache.FsxFileCacheDataRepositoryAssociationNfs")]
    public class FsxFileCacheDataRepositoryAssociationNfs : aws.FsxFileCache.IFsxFileCacheDataRepositoryAssociationNfs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#version FsxFileCache#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#dns_ips FsxFileCache#dns_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DnsIps
        {
            get;
            set;
        }
    }
}
