using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SecurityCenterAssessment
{
    [JsiiInterface(nativeType: typeof(ISecurityCenterAssessmentStatus), fullyQualifiedName: "azurerm.securityCenterAssessment.SecurityCenterAssessmentStatus")]
    public interface ISecurityCenterAssessmentStatus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#code SecurityCenterAssessment#code}.</summary>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
        string Code
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#cause SecurityCenterAssessment#cause}.</summary>
        [JsiiProperty(name: "cause", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cause
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#description SecurityCenterAssessment#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityCenterAssessmentStatus), fullyQualifiedName: "azurerm.securityCenterAssessment.SecurityCenterAssessmentStatus")]
        internal sealed class _Proxy : DeputyBase, azurerm.SecurityCenterAssessment.ISecurityCenterAssessmentStatus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#code SecurityCenterAssessment#code}.</summary>
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"string\"}")]
            public string Code
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#cause SecurityCenterAssessment#cause}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cause", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cause
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_assessment#description SecurityCenterAssessment#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
