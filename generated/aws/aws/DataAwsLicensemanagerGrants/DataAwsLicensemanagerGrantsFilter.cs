using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLicensemanagerGrants
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsLicensemanagerGrants.DataAwsLicensemanagerGrantsFilter")]
    public class DataAwsLicensemanagerGrantsFilter : aws.DataAwsLicensemanagerGrants.IDataAwsLicensemanagerGrantsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#name DataAwsLicensemanagerGrants#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/licensemanager_grants#values DataAwsLicensemanagerGrants#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
