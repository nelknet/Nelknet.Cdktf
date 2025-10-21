using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamDirectoryConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstreamDirectoryConfig.AppstreamDirectoryConfigServiceAccountCredentials")]
    public class AppstreamDirectoryConfigServiceAccountCredentials : aws.AppstreamDirectoryConfig.IAppstreamDirectoryConfigServiceAccountCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_directory_config#account_name AppstreamDirectoryConfig#account_name}.</summary>
        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_directory_config#account_password AppstreamDirectoryConfig#account_password}.</summary>
        [JsiiProperty(name: "accountPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountPassword
        {
            get;
            set;
        }
    }
}
