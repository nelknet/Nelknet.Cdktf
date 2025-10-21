using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCustomerGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsCustomerGateway.DataAwsCustomerGatewayFilter")]
    public class DataAwsCustomerGatewayFilter : aws.DataAwsCustomerGateway.IDataAwsCustomerGatewayFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#name DataAwsCustomerGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#values DataAwsCustomerGateway#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
