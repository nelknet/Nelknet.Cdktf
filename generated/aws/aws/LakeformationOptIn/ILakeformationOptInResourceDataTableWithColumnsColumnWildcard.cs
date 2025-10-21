using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    [JsiiInterface(nativeType: typeof(ILakeformationOptInResourceDataTableWithColumnsColumnWildcard), fullyQualifiedName: "aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumnsColumnWildcard")]
    public interface ILakeformationOptInResourceDataTableWithColumnsColumnWildcard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#excluded_column_names LakeformationOptIn#excluded_column_names}.</summary>
        [JsiiProperty(name: "excludedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedColumnNames
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationOptInResourceDataTableWithColumnsColumnWildcard), fullyQualifiedName: "aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumnsColumnWildcard")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationOptIn.ILakeformationOptInResourceDataTableWithColumnsColumnWildcard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#excluded_column_names LakeformationOptIn#excluded_column_names}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedColumnNames
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
