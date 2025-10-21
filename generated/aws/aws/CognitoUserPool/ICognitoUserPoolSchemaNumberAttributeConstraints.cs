using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSchemaNumberAttributeConstraints), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraints")]
    public interface ICognitoUserPoolSchemaNumberAttributeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#max_value CognitoUserPool#max_value}.</summary>
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxValue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#min_value CognitoUserPool#min_value}.</summary>
        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSchemaNumberAttributeConstraints), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolSchemaNumberAttributeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#max_value CognitoUserPool#max_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxValue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#min_value CognitoUserPool#min_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
