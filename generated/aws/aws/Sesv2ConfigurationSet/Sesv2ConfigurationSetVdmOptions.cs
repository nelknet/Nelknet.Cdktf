using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiByValue(fqn: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions")]
    public class Sesv2ConfigurationSetVdmOptions : aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions
    {
        /// <summary>dashboard_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#dashboard_options Sesv2ConfigurationSet#dashboard_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dashboardOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsDashboardOptions\"}", isOptional: true)]
        public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsDashboardOptions? DashboardOptions
        {
            get;
            set;
        }

        /// <summary>guardian_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#guardian_options Sesv2ConfigurationSet#guardian_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "guardianOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptionsGuardianOptions\"}", isOptional: true)]
        public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptionsGuardianOptions? GuardianOptions
        {
            get;
            set;
        }
    }
}
