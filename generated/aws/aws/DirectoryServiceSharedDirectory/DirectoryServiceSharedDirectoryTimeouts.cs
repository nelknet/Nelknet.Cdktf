using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceSharedDirectory
{
    [JsiiByValue(fqn: "aws.directoryServiceSharedDirectory.DirectoryServiceSharedDirectoryTimeouts")]
    public class DirectoryServiceSharedDirectoryTimeouts : aws.DirectoryServiceSharedDirectory.IDirectoryServiceSharedDirectoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#delete DirectoryServiceSharedDirectory#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
