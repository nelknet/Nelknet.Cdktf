using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiByValue(fqn: "aws.transferServer.TransferServerS3StorageOptions")]
    public class TransferServerS3StorageOptions : aws.TransferServer.ITransferServerS3StorageOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#directory_listing_optimization TransferServer#directory_listing_optimization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "directoryListingOptimization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DirectoryListingOptimization
        {
            get;
            set;
        }
    }
}
