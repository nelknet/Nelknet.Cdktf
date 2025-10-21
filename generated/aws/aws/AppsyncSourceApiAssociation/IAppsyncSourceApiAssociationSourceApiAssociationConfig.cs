using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncSourceApiAssociation
{
    [JsiiInterface(nativeType: typeof(IAppsyncSourceApiAssociationSourceApiAssociationConfig), fullyQualifiedName: "aws.appsyncSourceApiAssociation.AppsyncSourceApiAssociationSourceApiAssociationConfig")]
    public interface IAppsyncSourceApiAssociationSourceApiAssociationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#merge_type AppsyncSourceApiAssociation#merge_type}.</summary>
        [JsiiProperty(name: "mergeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MergeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncSourceApiAssociationSourceApiAssociationConfig), fullyQualifiedName: "aws.appsyncSourceApiAssociation.AppsyncSourceApiAssociationSourceApiAssociationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncSourceApiAssociation.IAppsyncSourceApiAssociationSourceApiAssociationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_source_api_association#merge_type AppsyncSourceApiAssociation#merge_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mergeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MergeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
