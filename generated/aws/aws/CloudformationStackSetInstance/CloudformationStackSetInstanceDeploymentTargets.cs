using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackSetInstance
{
    [JsiiByValue(fqn: "aws.cloudformationStackSetInstance.CloudformationStackSetInstanceDeploymentTargets")]
    public class CloudformationStackSetInstanceDeploymentTargets : aws.CloudformationStackSetInstance.ICloudformationStackSetInstanceDeploymentTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#account_filter_type CloudformationStackSetInstance#account_filter_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountFilterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountFilterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#accounts CloudformationStackSetInstance#accounts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Accounts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#accounts_url CloudformationStackSetInstance#accounts_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountsUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_set_instance#organizational_unit_ids CloudformationStackSetInstance#organizational_unit_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OrganizationalUnitIds
        {
            get;
            set;
        }
    }
}
