using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsElasticacheUser
{
    [JsiiInterface(nativeType: typeof(IDataAwsElasticacheUserAuthenticationMode), fullyQualifiedName: "aws.dataAwsElasticacheUser.DataAwsElasticacheUserAuthenticationMode")]
    public interface IDataAwsElasticacheUserAuthenticationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#password_count DataAwsElasticacheUser#password_count}.</summary>
        [JsiiProperty(name: "passwordCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PasswordCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#type DataAwsElasticacheUser#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsElasticacheUserAuthenticationMode), fullyQualifiedName: "aws.dataAwsElasticacheUser.DataAwsElasticacheUserAuthenticationMode")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsElasticacheUser.IDataAwsElasticacheUserAuthenticationMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#password_count DataAwsElasticacheUser#password_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PasswordCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/elasticache_user#type DataAwsElasticacheUser#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
