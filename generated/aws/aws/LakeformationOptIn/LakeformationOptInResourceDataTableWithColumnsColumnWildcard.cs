using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    [JsiiByValue(fqn: "aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumnsColumnWildcard")]
    public class LakeformationOptInResourceDataTableWithColumnsColumnWildcard : aws.LakeformationOptIn.ILakeformationOptInResourceDataTableWithColumnsColumnWildcard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#excluded_column_names LakeformationOptIn#excluded_column_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedColumnNames
        {
            get;
            set;
        }
    }
}
