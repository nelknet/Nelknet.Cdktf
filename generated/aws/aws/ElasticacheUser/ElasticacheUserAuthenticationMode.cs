using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticacheUser.ElasticacheUserAuthenticationMode")]
    public class ElasticacheUserAuthenticationMode : aws.ElasticacheUser.IElasticacheUserAuthenticationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#type ElasticacheUser#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_user#passwords ElasticacheUser#passwords}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Passwords
        {
            get;
            set;
        }
    }
}
