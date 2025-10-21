using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationPermissions
{
    [JsiiInterface(nativeType: typeof(ILakeformationPermissionsLfTagPolicy), fullyQualifiedName: "aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicy")]
    public interface ILakeformationPermissionsLfTagPolicy
    {
        /// <summary>expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#expression LakeformationPermissions#expression}
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicyExpression\"},\"kind\":\"array\"}}]}}")]
        object Expression
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#resource_type LakeformationPermissions#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_id LakeformationPermissions#catalog_id}.</summary>
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationPermissionsLfTagPolicy), fullyQualifiedName: "aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#expression LakeformationPermissions#expression}
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicyExpression\"},\"kind\":\"array\"}}]}}")]
            public object Expression
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#resource_type LakeformationPermissions#resource_type}.</summary>
            [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_id LakeformationPermissions#catalog_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
