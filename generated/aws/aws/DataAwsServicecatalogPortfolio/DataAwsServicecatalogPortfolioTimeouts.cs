using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogPortfolio
{
    [JsiiByValue(fqn: "aws.dataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolioTimeouts")]
    public class DataAwsServicecatalogPortfolioTimeouts : aws.DataAwsServicecatalogPortfolio.IDataAwsServicecatalogPortfolioTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio#read DataAwsServicecatalogPortfolio#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
