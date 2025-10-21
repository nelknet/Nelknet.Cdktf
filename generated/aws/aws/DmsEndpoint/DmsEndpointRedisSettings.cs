using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DmsEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dmsEndpoint.DmsEndpointRedisSettings")]
    public class DmsEndpointRedisSettings : aws.DmsEndpoint.IDmsEndpointRedisSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_type DmsEndpoint#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#port DmsEndpoint#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#server_name DmsEndpoint#server_name}.</summary>
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServerName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_password DmsEndpoint#auth_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#auth_user_name DmsEndpoint#auth_user_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authUserName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthUserName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#ssl_ca_certificate_arn DmsEndpoint#ssl_ca_certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCaCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslCaCertificateArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dms_endpoint#ssl_security_protocol DmsEndpoint#ssl_security_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslSecurityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslSecurityProtocol
        {
            get;
            set;
        }
    }
}
