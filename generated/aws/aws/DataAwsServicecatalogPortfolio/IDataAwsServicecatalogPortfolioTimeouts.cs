using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogPortfolio
{
    [JsiiInterface(nativeType: typeof(IDataAwsServicecatalogPortfolioTimeouts), fullyQualifiedName: "aws.dataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolioTimeouts")]
    public interface IDataAwsServicecatalogPortfolioTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio#read DataAwsServicecatalogPortfolio#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsServicecatalogPortfolioTimeouts), fullyQualifiedName: "aws.dataAwsServicecatalogPortfolio.DataAwsServicecatalogPortfolioTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsServicecatalogPortfolio.IDataAwsServicecatalogPortfolioTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_portfolio#read DataAwsServicecatalogPortfolio#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
