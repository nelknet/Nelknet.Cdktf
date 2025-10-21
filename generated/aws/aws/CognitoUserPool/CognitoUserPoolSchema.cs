using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolSchema")]
    public class CognitoUserPoolSchema : aws.CognitoUserPool.ICognitoUserPoolSchema
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#attribute_data_type CognitoUserPool#attribute_data_type}.</summary>
        [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeDataType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _developerOnlyAttribute;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#developer_only_attribute CognitoUserPool#developer_only_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DeveloperOnlyAttribute
        {
            get => _developerOnlyAttribute;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _developerOnlyAttribute = value;
            }
        }

        private object? _mutable;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#mutable CognitoUserPool#mutable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mutable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Mutable
        {
            get => _mutable;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _mutable = value;
            }
        }

        /// <summary>number_attribute_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#number_attribute_constraints CognitoUserPool#number_attribute_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaNumberAttributeConstraints\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolSchemaNumberAttributeConstraints? NumberAttributeConstraints
        {
            get;
            set;
        }

        private object? _required;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#required CognitoUserPool#required}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Required
        {
            get => _required;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _required = value;
            }
        }

        /// <summary>string_attribute_constraints block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#string_attribute_constraints CognitoUserPool#string_attribute_constraints}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaStringAttributeConstraints\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolSchemaStringAttributeConstraints? StringAttributeConstraints
        {
            get;
            set;
        }
    }
}
