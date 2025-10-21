using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicy
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal")]
    public interface IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#entity_id VerifiedpermissionsPolicy#entity_id}.</summary>
        [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
        string EntityId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#entity_type VerifiedpermissionsPolicy#entity_type}.</summary>
        [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
        string EntityType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionTemplateLinkedPrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#entity_id VerifiedpermissionsPolicy#entity_id}.</summary>
            [JsiiProperty(name: "entityId", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#entity_type VerifiedpermissionsPolicy#entity_type}.</summary>
            [JsiiProperty(name: "entityType", typeJson: "{\"primitive\":\"string\"}")]
            public string EntityType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
