using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticacheUser
{
    [JsiiByValue(fqn: "aws.dataAwsElasticacheUser.DataAwsElasticacheUserAuthenticationMode")]
    public class DataAwsElasticacheUserAuthenticationMode : aws.DataAwsElasticacheUser.IDataAwsElasticacheUserAuthenticationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#password_count DataAwsElasticacheUser#password_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PasswordCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#type DataAwsElasticacheUser#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
