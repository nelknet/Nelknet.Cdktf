using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServicecatalogOrganizationsAccess
{
    [JsiiByValue(fqn: "aws.servicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccessTimeouts")]
    public class ServicecatalogOrganizationsAccessTimeouts : aws.ServicecatalogOrganizationsAccess.IServicecatalogOrganizationsAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access#read ServicecatalogOrganizationsAccess#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
