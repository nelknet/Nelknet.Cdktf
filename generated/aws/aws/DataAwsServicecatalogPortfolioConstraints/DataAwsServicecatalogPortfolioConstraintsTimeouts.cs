using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogPortfolioConstraints
{
    [JsiiByValue(fqn: "aws.dataAwsServicecatalogPortfolioConstraints.DataAwsServicecatalogPortfolioConstraintsTimeouts")]
    public class DataAwsServicecatalogPortfolioConstraintsTimeouts : aws.DataAwsServicecatalogPortfolioConstraints.IDataAwsServicecatalogPortfolioConstraintsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio_constraints#read DataAwsServicecatalogPortfolioConstraints#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
