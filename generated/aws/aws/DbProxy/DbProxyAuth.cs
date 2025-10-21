using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbProxy
{
    [JsiiByValue(fqn: "aws.dbProxy.DbProxyAuth")]
    public class DbProxyAuth : aws.DbProxy.IDbProxyAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#auth_scheme DbProxy#auth_scheme}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthScheme
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#client_password_auth_type DbProxy#client_password_auth_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientPasswordAuthType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientPasswordAuthType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#description DbProxy#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#iam_auth DbProxy#iam_auth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iamAuth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IamAuth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#secret_arn DbProxy#secret_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_proxy#username DbProxy#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
