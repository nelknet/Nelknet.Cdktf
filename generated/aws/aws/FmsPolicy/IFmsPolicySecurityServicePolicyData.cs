using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiInterface(nativeType: typeof(IFmsPolicySecurityServicePolicyData), fullyQualifiedName: "aws.fmsPolicy.FmsPolicySecurityServicePolicyData")]
    public interface IFmsPolicySecurityServicePolicyData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#type FmsPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#managed_service_data FmsPolicy#managed_service_data}.</summary>
        [JsiiProperty(name: "managedServiceData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedServiceData
        {
            get
            {
                return null;
            }
        }

        /// <summary>policy_option block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#policy_option FmsPolicy#policy_option}
        /// </remarks>
        [JsiiProperty(name: "policyOption", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOption\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption? PolicyOption
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFmsPolicySecurityServicePolicyData), fullyQualifiedName: "aws.fmsPolicy.FmsPolicySecurityServicePolicyData")]
        internal sealed class _Proxy : DeputyBase, aws.FmsPolicy.IFmsPolicySecurityServicePolicyData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#type FmsPolicy#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#managed_service_data FmsPolicy#managed_service_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedServiceData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedServiceData
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>policy_option block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#policy_option FmsPolicy#policy_option}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "policyOption", typeJson: "{\"fqn\":\"aws.fmsPolicy.FmsPolicySecurityServicePolicyDataPolicyOption\"}", isOptional: true)]
            public aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption? PolicyOption
            {
                get => GetInstanceProperty<aws.FmsPolicy.IFmsPolicySecurityServicePolicyDataPolicyOption?>();
            }
        }
    }
}
