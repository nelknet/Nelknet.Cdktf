using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    [JsiiInterface(nativeType: typeof(ILakeformationOptInPrincipal), fullyQualifiedName: "aws.lakeformationOptIn.LakeformationOptInPrincipal")]
    public interface ILakeformationOptInPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_lake_principal_identifier LakeformationOptIn#data_lake_principal_identifier}.</summary>
        [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string DataLakePrincipalIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationOptInPrincipal), fullyQualifiedName: "aws.lakeformationOptIn.LakeformationOptInPrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationOptIn.ILakeformationOptInPrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_lake_principal_identifier LakeformationOptIn#data_lake_principal_identifier}.</summary>
            [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string DataLakePrincipalIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
