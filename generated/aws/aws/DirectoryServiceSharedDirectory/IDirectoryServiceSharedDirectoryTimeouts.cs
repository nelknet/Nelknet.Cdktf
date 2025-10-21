using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DirectoryServiceSharedDirectory
{
    [JsiiInterface(nativeType: typeof(IDirectoryServiceSharedDirectoryTimeouts), fullyQualifiedName: "aws.directoryServiceSharedDirectory.DirectoryServiceSharedDirectoryTimeouts")]
    public interface IDirectoryServiceSharedDirectoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#delete DirectoryServiceSharedDirectory#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDirectoryServiceSharedDirectoryTimeouts), fullyQualifiedName: "aws.directoryServiceSharedDirectory.DirectoryServiceSharedDirectoryTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DirectoryServiceSharedDirectory.IDirectoryServiceSharedDirectoryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/directory_service_shared_directory#delete DirectoryServiceSharedDirectory#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
