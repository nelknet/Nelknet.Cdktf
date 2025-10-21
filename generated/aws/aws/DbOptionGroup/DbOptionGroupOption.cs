using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbOptionGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dbOptionGroup.DbOptionGroupOption")]
    public class DbOptionGroupOption : aws.DbOptionGroup.IDbOptionGroupOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#option_name DbOptionGroup#option_name}.</summary>
        [JsiiProperty(name: "optionName", typeJson: "{\"primitive\":\"string\"}")]
        public string OptionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#db_security_group_memberships DbOptionGroup#db_security_group_memberships}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DbSecurityGroupMemberships
        {
            get;
            set;
        }

        private object? _optionSettings;

        /// <summary>option_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#option_settings DbOptionGroup#option_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optionSettings", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.dbOptionGroup.DbOptionGroupOptionOptionSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OptionSettings
        {
            get => _optionSettings;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.DbOptionGroup.IDbOptionGroupOptionOptionSettings[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DbOptionGroup.IDbOptionGroupOptionOptionSettings).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _optionSettings = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#port DbOptionGroup#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#version DbOptionGroup#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_option_group#vpc_security_group_memberships DbOptionGroup#vpc_security_group_memberships}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpcSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpcSecurityGroupMemberships
        {
            get;
            set;
        }
    }
}
