using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudformationStackInstances
{
    [JsiiByValue(fqn: "aws.cloudformationStackInstances.CloudformationStackInstancesDeploymentTargets")]
    public class CloudformationStackInstancesDeploymentTargets : aws.CloudformationStackInstances.ICloudformationStackInstancesDeploymentTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#account_filter_type CloudformationStackInstances#account_filter_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountFilterType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountFilterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#accounts CloudformationStackInstances#accounts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Accounts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#accounts_url CloudformationStackInstances#accounts_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountsUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountsUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_stack_instances#organizational_unit_ids CloudformationStackInstances#organizational_unit_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OrganizationalUnitIds
        {
            get;
            set;
        }
    }
}
