using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxDataRepositoryAssociation
{
    [JsiiInterface(nativeType: typeof(IFsxDataRepositoryAssociationS3AutoExportPolicy), fullyQualifiedName: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicy")]
    public interface IFsxDataRepositoryAssociationS3AutoExportPolicy
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

        [JsiiTypeProxy(nativeType: typeof(IFsxDataRepositoryAssociationS3AutoExportPolicy), fullyQualifiedName: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoExportPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoExportPolicy
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
