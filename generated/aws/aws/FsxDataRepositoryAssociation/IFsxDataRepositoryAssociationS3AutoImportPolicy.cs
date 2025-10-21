using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxDataRepositoryAssociation
{
    [JsiiInterface(nativeType: typeof(IFsxDataRepositoryAssociationS3AutoImportPolicy), fullyQualifiedName: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy")]
    public interface IFsxDataRepositoryAssociationS3AutoImportPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#events FsxDataRepositoryAssociation#events}.</summary>
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Events
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxDataRepositoryAssociationS3AutoImportPolicy), fullyQualifiedName: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#events FsxDataRepositoryAssociation#events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Events
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
