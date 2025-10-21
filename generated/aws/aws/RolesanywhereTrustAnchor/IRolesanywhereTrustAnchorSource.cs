using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RolesanywhereTrustAnchor
{
    [JsiiInterface(nativeType: typeof(IRolesanywhereTrustAnchorSource), fullyQualifiedName: "aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSource")]
    public interface IRolesanywhereTrustAnchorSource
    {
        /// <summary>source_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#source_data RolesanywhereTrustAnchor#source_data}
        /// </remarks>
        [JsiiProperty(name: "sourceData", typeJson: "{\"fqn\":\"aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData\"}")]
        aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData SourceData
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#source_type RolesanywhereTrustAnchor#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRolesanywhereTrustAnchorSource), fullyQualifiedName: "aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSource")]
        internal sealed class _Proxy : DeputyBase, aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>source_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#source_data RolesanywhereTrustAnchor#source_data}
            /// </remarks>
            [JsiiProperty(name: "sourceData", typeJson: "{\"fqn\":\"aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData\"}")]
            public aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData SourceData
            {
                get => GetInstanceProperty<aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rolesanywhere_trust_anchor#source_type RolesanywhereTrustAnchor#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
