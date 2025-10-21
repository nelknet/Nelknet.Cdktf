using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxDataRepositoryAssociation
{
    [JsiiByValue(fqn: "aws.fsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3AutoImportPolicy")]
    public class FsxDataRepositoryAssociationS3AutoImportPolicy : aws.FsxDataRepositoryAssociation.IFsxDataRepositoryAssociationS3AutoImportPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#events FsxDataRepositoryAssociation#events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "events", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Events
        {
            get;
            set;
        }
    }
}
