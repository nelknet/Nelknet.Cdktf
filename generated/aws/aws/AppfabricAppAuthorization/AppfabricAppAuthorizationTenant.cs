using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationTenant")]
    public class AppfabricAppAuthorizationTenant : aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationTenant
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tenant_display_name AppfabricAppAuthorization#tenant_display_name}.</summary>
        [JsiiProperty(name: "tenantDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantDisplayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tenant_identifier AppfabricAppAuthorization#tenant_identifier}.</summary>
        [JsiiProperty(name: "tenantIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string TenantIdentifier
        {
            get;
            set;
        }
    }
}
