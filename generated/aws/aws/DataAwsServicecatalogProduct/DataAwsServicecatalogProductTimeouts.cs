using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogProduct
{
    [JsiiByValue(fqn: "aws.dataAwsServicecatalogProduct.DataAwsServicecatalogProductTimeouts")]
    public class DataAwsServicecatalogProductTimeouts : aws.DataAwsServicecatalogProduct.IDataAwsServicecatalogProductTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_product#read DataAwsServicecatalogProduct#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
