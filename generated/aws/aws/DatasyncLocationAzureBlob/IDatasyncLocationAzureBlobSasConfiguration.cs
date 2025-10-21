using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationAzureBlob
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationAzureBlobSasConfiguration), fullyQualifiedName: "aws.datasyncLocationAzureBlob.DatasyncLocationAzureBlobSasConfiguration")]
    public interface IDatasyncLocationAzureBlobSasConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#token DatasyncLocationAzureBlob#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        string Token
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationAzureBlobSasConfiguration), fullyQualifiedName: "aws.datasyncLocationAzureBlob.DatasyncLocationAzureBlobSasConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationAzureBlob.IDatasyncLocationAzureBlobSasConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#token DatasyncLocationAzureBlob#token}.</summary>
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
            public string Token
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
