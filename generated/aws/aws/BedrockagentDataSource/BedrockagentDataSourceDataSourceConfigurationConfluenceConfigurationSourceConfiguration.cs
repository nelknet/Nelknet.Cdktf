using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentDataSource.BedrockagentDataSourceDataSourceConfigurationConfluenceConfigurationSourceConfiguration")]
    public class BedrockagentDataSourceDataSourceConfigurationConfluenceConfigurationSourceConfiguration : aws.BedrockagentDataSource.IBedrockagentDataSourceDataSourceConfigurationConfluenceConfigurationSourceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#auth_type BedrockagentDataSource#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#credentials_secret_arn BedrockagentDataSource#credentials_secret_arn}.</summary>
        [JsiiProperty(name: "credentialsSecretArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialsSecretArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#host_type BedrockagentDataSource#host_type}.</summary>
        [JsiiProperty(name: "hostType", typeJson: "{\"primitive\":\"string\"}")]
        public string HostType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrockagent_data_source#host_url BedrockagentDataSource#host_url}.</summary>
        [JsiiProperty(name: "hostUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string HostUrl
        {
            get;
            set;
        }
    }
}
