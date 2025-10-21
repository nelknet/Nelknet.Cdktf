using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationHdfs
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationHdfsQopConfiguration), fullyQualifiedName: "aws.datasyncLocationHdfs.DatasyncLocationHdfsQopConfiguration")]
    public interface IDatasyncLocationHdfsQopConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#data_transfer_protection DatasyncLocationHdfs#data_transfer_protection}.</summary>
        [JsiiProperty(name: "dataTransferProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataTransferProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#rpc_protection DatasyncLocationHdfs#rpc_protection}.</summary>
        [JsiiProperty(name: "rpcProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RpcProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationHdfsQopConfiguration), fullyQualifiedName: "aws.datasyncLocationHdfs.DatasyncLocationHdfsQopConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationHdfs.IDatasyncLocationHdfsQopConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#data_transfer_protection DatasyncLocationHdfs#data_transfer_protection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataTransferProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataTransferProtection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#rpc_protection DatasyncLocationHdfs#rpc_protection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rpcProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RpcProtection
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
