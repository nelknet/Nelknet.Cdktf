using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppfabricAppAuthorization
{
    [JsiiInterface(nativeType: typeof(IAppfabricAppAuthorizationTenant), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationTenant")]
    public interface IAppfabricAppAuthorizationTenant
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tenant_display_name AppfabricAppAuthorization#tenant_display_name}.</summary>
        [JsiiProperty(name: "tenantDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        string TenantDisplayName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tenant_identifier AppfabricAppAuthorization#tenant_identifier}.</summary>
        [JsiiProperty(name: "tenantIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string TenantIdentifier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppfabricAppAuthorizationTenant), fullyQualifiedName: "aws.appfabricAppAuthorization.AppfabricAppAuthorizationTenant")]
        internal sealed class _Proxy : DeputyBase, aws.AppfabricAppAuthorization.IAppfabricAppAuthorizationTenant
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tenant_display_name AppfabricAppAuthorization#tenant_display_name}.</summary>
            [JsiiProperty(name: "tenantDisplayName", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantDisplayName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appfabric_app_authorization#tenant_identifier AppfabricAppAuthorization#tenant_identifier}.</summary>
            [JsiiProperty(name: "tenantIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string TenantIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
