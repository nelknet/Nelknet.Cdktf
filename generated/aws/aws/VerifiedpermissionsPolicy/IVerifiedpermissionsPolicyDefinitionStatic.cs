using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedpermissionsPolicy
{
    [JsiiInterface(nativeType: typeof(IVerifiedpermissionsPolicyDefinitionStatic), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionStatic")]
    public interface IVerifiedpermissionsPolicyDefinitionStatic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#statement VerifiedpermissionsPolicy#statement}.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"string\"}")]
        string Statement
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#description VerifiedpermissionsPolicy#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedpermissionsPolicyDefinitionStatic), fullyQualifiedName: "aws.verifiedpermissionsPolicy.VerifiedpermissionsPolicyDefinitionStatic")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedpermissionsPolicy.IVerifiedpermissionsPolicyDefinitionStatic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#statement VerifiedpermissionsPolicy#statement}.</summary>
            [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"string\"}")]
            public string Statement
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedpermissions_policy#description VerifiedpermissionsPolicy#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
