using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferServer
{
    [JsiiInterface(nativeType: typeof(ITransferServerS3StorageOptions), fullyQualifiedName: "aws.transferServer.TransferServerS3StorageOptions")]
    public interface ITransferServerS3StorageOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#directory_listing_optimization TransferServer#directory_listing_optimization}.</summary>
        [JsiiProperty(name: "directoryListingOptimization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DirectoryListingOptimization
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITransferServerS3StorageOptions), fullyQualifiedName: "aws.transferServer.TransferServerS3StorageOptions")]
        internal sealed class _Proxy : DeputyBase, aws.TransferServer.ITransferServerS3StorageOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_server#directory_listing_optimization TransferServer#directory_listing_optimization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "directoryListingOptimization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DirectoryListingOptimization
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
