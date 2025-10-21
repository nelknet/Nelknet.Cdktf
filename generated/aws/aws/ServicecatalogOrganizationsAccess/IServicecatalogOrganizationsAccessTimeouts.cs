using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ServicecatalogOrganizationsAccess
{
    [JsiiInterface(nativeType: typeof(IServicecatalogOrganizationsAccessTimeouts), fullyQualifiedName: "aws.servicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccessTimeouts")]
    public interface IServicecatalogOrganizationsAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access#read ServicecatalogOrganizationsAccess#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServicecatalogOrganizationsAccessTimeouts), fullyQualifiedName: "aws.servicecatalogOrganizationsAccess.ServicecatalogOrganizationsAccessTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.ServicecatalogOrganizationsAccess.IServicecatalogOrganizationsAccessTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/servicecatalog_organizations_access#read ServicecatalogOrganizationsAccess#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
