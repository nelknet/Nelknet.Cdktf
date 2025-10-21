using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsPricingProduct
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsPricingProduct.DataAwsPricingProductFilters")]
    public class DataAwsPricingProductFilters : aws.DataAwsPricingProduct.IDataAwsPricingProductFilters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/pricing_product#field DataAwsPricingProduct#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/pricing_product#value DataAwsPricingProduct#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
