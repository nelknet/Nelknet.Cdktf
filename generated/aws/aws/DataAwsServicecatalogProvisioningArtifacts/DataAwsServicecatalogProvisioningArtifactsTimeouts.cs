using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogProvisioningArtifacts
{
    [JsiiByValue(fqn: "aws.dataAwsServicecatalogProvisioningArtifacts.DataAwsServicecatalogProvisioningArtifactsTimeouts")]
    public class DataAwsServicecatalogProvisioningArtifactsTimeouts : aws.DataAwsServicecatalogProvisioningArtifacts.IDataAwsServicecatalogProvisioningArtifactsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_provisioning_artifacts#read DataAwsServicecatalogProvisioningArtifacts#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
