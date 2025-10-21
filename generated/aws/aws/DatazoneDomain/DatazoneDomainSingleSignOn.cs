using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatazoneDomain
{
    [JsiiByValue(fqn: "aws.datazoneDomain.DatazoneDomainSingleSignOn")]
    public class DatazoneDomainSingleSignOn : aws.DatazoneDomain.IDatazoneDomainSingleSignOn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#type DatazoneDomain#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_domain#user_assignment DatazoneDomain#user_assignment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignment
        {
            get;
            set;
        }
    }
}
