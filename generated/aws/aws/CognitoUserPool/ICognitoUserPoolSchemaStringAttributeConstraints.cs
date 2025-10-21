using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolSchemaStringAttributeConstraints), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraints")]
    public interface ICognitoUserPoolSchemaStringAttributeConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#max_length CognitoUserPool#max_length}.</summary>
        [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxLength
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#min_length CognitoUserPool#min_length}.</summary>
        [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinLength
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolSchemaStringAttributeConstraints), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraints")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolSchemaStringAttributeConstraints
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#max_length CognitoUserPool#max_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxLength
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#min_length CognitoUserPool#min_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinLength
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
