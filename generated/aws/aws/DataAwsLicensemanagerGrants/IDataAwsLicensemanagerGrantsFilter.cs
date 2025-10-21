using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLicensemanagerGrants
{
    [JsiiInterface(nativeType: typeof(IDataAwsLicensemanagerGrantsFilter), fullyQualifiedName: "aws.dataAwsLicensemanagerGrants.DataAwsLicensemanagerGrantsFilter")]
    public interface IDataAwsLicensemanagerGrantsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#name DataAwsLicensemanagerGrants#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#values DataAwsLicensemanagerGrants#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLicensemanagerGrantsFilter), fullyQualifiedName: "aws.dataAwsLicensemanagerGrants.DataAwsLicensemanagerGrantsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLicensemanagerGrants.IDataAwsLicensemanagerGrantsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#name DataAwsLicensemanagerGrants#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#values DataAwsLicensemanagerGrants#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
