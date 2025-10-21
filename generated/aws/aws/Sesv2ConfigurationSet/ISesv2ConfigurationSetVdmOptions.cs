using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetVdmOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions")]
    public interface ISesv2ConfigurationSetVdmOptions
    {
        /// <summary>dashboard_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#dashboard_options Sesv2ConfigurationSet#dashboard_options}
        /// </remarks>
        [JsiiProperty(name: "dashboardOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions? DashboardOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>guardian_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#guardian_options Sesv2ConfigurationSet#guardian_options}
        /// </remarks>
        [JsiiProperty(name: "guardianOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions? GuardianOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetVdmOptions), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>dashboard_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#dashboard_options Sesv2ConfigurationSet#dashboard_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dashboardOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions? DashboardOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions?>();
            }

            /// <summary>guardian_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#guardian_options Sesv2ConfigurationSet#guardian_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "guardianOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions? GuardianOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions?>();
            }
        }
    }
}
