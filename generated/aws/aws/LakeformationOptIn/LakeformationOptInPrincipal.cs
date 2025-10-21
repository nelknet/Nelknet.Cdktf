using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lakeformationOptIn.LakeformationOptInPrincipal")]
    public class LakeformationOptInPrincipal : aws.LakeformationOptIn.ILakeformationOptInPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_lake_principal_identifier LakeformationOptIn#data_lake_principal_identifier}.</summary>
        [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string DataLakePrincipalIdentifier
        {
            get;
            set;
        }
    }
}
