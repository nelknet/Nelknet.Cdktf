using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MqBroker
{
    [JsiiByValue(fqn: "aws.mqBroker.MqBrokerLdapServerMetadata")]
    public class MqBrokerLdapServerMetadata : aws.MqBroker.IMqBrokerLdapServerMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#hosts MqBroker#hosts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Hosts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_base MqBroker#role_base}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleBase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_name MqBroker#role_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_search_matching MqBroker#role_search_matching}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleSearchMatching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleSearchMatching
        {
            get;
            set;
        }

        private object? _roleSearchSubtree;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_search_subtree MqBroker#role_search_subtree}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleSearchSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RoleSearchSubtree
        {
            get => _roleSearchSubtree;
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
                _roleSearchSubtree = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#service_account_password MqBroker#service_account_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#service_account_username MqBroker#service_account_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_base MqBroker#user_base}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserBase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_role_name MqBroker#user_role_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userRoleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserRoleName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_search_matching MqBroker#user_search_matching}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userSearchMatching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserSearchMatching
        {
            get;
            set;
        }

        private object? _userSearchSubtree;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_search_subtree MqBroker#user_search_subtree}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userSearchSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UserSearchSubtree
        {
            get => _userSearchSubtree;
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
                _userSearchSubtree = value;
            }
        }
    }
}
