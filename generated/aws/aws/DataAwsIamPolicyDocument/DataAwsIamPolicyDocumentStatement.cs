using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIamPolicyDocument
{
    [JsiiByValue(fqn: "aws.dataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatement")]
    public class DataAwsIamPolicyDocumentStatement : aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#actions DataAwsIamPolicyDocument#actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Actions
        {
            get;
            set;
        }

        private object? _condition;

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#condition DataAwsIamPolicyDocument#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatementCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Condition
        {
            get => _condition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _condition = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#effect DataAwsIamPolicyDocument#effect}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Effect
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#not_actions DataAwsIamPolicyDocument#not_actions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotActions
        {
            get;
            set;
        }

        private object? _notPrincipals;

        /// <summary>not_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#not_principals DataAwsIamPolicyDocument#not_principals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatementNotPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NotPrincipals
        {
            get => _notPrincipals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementNotPrincipals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementNotPrincipals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _notPrincipals = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#not_resources DataAwsIamPolicyDocument#not_resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notResources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NotResources
        {
            get;
            set;
        }

        private object? _principals;

        /// <summary>principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#principals DataAwsIamPolicyDocument#principals}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dataAwsIamPolicyDocument.DataAwsIamPolicyDocumentStatementPrincipals\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Principals
        {
            get => _principals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementPrincipals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DataAwsIamPolicyDocument.IDataAwsIamPolicyDocumentStatementPrincipals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principals = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#resources DataAwsIamPolicyDocument#resources}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Resources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_policy_document#sid DataAwsIamPolicyDocument#sid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sid
        {
            get;
            set;
        }
    }
}
