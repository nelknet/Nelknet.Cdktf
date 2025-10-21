using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationAzureBlob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.datasyncLocationAzureBlob.DatasyncLocationAzureBlobSasConfiguration")]
    public class DatasyncLocationAzureBlobSasConfiguration : aws.DatasyncLocationAzureBlob.IDatasyncLocationAzureBlobSasConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_azure_blob#token DatasyncLocationAzureBlob#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public string Token
        {
            get;
            set;
        }
    }
}
