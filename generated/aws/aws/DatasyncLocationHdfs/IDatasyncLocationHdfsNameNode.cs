using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationHdfs
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationHdfsNameNode), fullyQualifiedName: "aws.datasyncLocationHdfs.DatasyncLocationHdfsNameNode")]
    public interface IDatasyncLocationHdfsNameNode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#hostname DatasyncLocationHdfs#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        string Hostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#port DatasyncLocationHdfs#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationHdfsNameNode), fullyQualifiedName: "aws.datasyncLocationHdfs.DatasyncLocationHdfsNameNode")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationHdfs.IDatasyncLocationHdfsNameNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#hostname DatasyncLocationHdfs#hostname}.</summary>
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
            public string Hostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_hdfs#port DatasyncLocationHdfs#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
