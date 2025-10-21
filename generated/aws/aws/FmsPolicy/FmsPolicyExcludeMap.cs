using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FmsPolicy
{
    [JsiiByValue(fqn: "aws.fmsPolicy.FmsPolicyExcludeMap")]
    public class FmsPolicyExcludeMap : aws.FmsPolicy.IFmsPolicyExcludeMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#account FmsPolicy#account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "account", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Account
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fms_policy#orgunit FmsPolicy#orgunit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "orgunit", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Orgunit
        {
            get;
            set;
        }
    }
}
