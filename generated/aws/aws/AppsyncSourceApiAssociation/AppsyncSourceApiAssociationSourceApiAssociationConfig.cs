using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncSourceApiAssociation
{
    [JsiiByValue(fqn: "aws.appsyncSourceApiAssociation.AppsyncSourceApiAssociationSourceApiAssociationConfig")]
    public class AppsyncSourceApiAssociationSourceApiAssociationConfig : aws.AppsyncSourceApiAssociation.IAppsyncSourceApiAssociationSourceApiAssociationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#merge_type AppsyncSourceApiAssociation#merge_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mergeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MergeType
        {
            get;
            set;
        }
    }
}
