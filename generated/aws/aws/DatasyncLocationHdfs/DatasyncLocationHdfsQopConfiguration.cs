using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationHdfs
{
    [JsiiByValue(fqn: "aws.datasyncLocationHdfs.DatasyncLocationHdfsQopConfiguration")]
    public class DatasyncLocationHdfsQopConfiguration : aws.DatasyncLocationHdfs.IDatasyncLocationHdfsQopConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#data_transfer_protection DatasyncLocationHdfs#data_transfer_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataTransferProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataTransferProtection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#rpc_protection DatasyncLocationHdfs#rpc_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rpcProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RpcProtection
        {
            get;
            set;
        }
    }
}
