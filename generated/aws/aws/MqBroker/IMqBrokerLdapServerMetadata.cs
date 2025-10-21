using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MqBroker
{
    [JsiiInterface(nativeType: typeof(IMqBrokerLdapServerMetadata), fullyQualifiedName: "aws.mqBroker.MqBrokerLdapServerMetadata")]
    public interface IMqBrokerLdapServerMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#hosts MqBroker#hosts}.</summary>
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Hosts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_base MqBroker#role_base}.</summary>
        [JsiiProperty(name: "roleBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleBase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_name MqBroker#role_name}.</summary>
        [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_search_matching MqBroker#role_search_matching}.</summary>
        [JsiiProperty(name: "roleSearchMatching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleSearchMatching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_search_subtree MqBroker#role_search_subtree}.</summary>
        [JsiiProperty(name: "roleSearchSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoleSearchSubtree
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#service_account_password MqBroker#service_account_password}.</summary>
        [JsiiProperty(name: "serviceAccountPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccountPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#service_account_username MqBroker#service_account_username}.</summary>
        [JsiiProperty(name: "serviceAccountUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccountUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_base MqBroker#user_base}.</summary>
        [JsiiProperty(name: "userBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserBase
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_role_name MqBroker#user_role_name}.</summary>
        [JsiiProperty(name: "userRoleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserRoleName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_search_matching MqBroker#user_search_matching}.</summary>
        [JsiiProperty(name: "userSearchMatching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserSearchMatching
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_search_subtree MqBroker#user_search_subtree}.</summary>
        [JsiiProperty(name: "userSearchSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UserSearchSubtree
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerLdapServerMetadata), fullyQualifiedName: "aws.mqBroker.MqBrokerLdapServerMetadata")]
        internal sealed class _Proxy : DeputyBase, aws.MqBroker.IMqBrokerLdapServerMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#hosts MqBroker#hosts}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Hosts
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_base MqBroker#role_base}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleBase
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_name MqBroker#role_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_search_matching MqBroker#role_search_matching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleSearchMatching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleSearchMatching
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#role_search_subtree MqBroker#role_search_subtree}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleSearchSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RoleSearchSubtree
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#service_account_password MqBroker#service_account_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccountPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccountPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#service_account_username MqBroker#service_account_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccountUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccountUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_base MqBroker#user_base}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserBase
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_role_name MqBroker#user_role_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userRoleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserRoleName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_search_matching MqBroker#user_search_matching}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userSearchMatching", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserSearchMatching
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#user_search_subtree MqBroker#user_search_subtree}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userSearchSubtree", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UserSearchSubtree
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
