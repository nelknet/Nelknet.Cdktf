using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiInterface(nativeType: typeof(IKendraIndexUserTokenConfigurations), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserTokenConfigurations")]
    public interface IKendraIndexUserTokenConfigurations
    {
        /// <summary>json_token_type_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#json_token_type_configuration KendraIndex#json_token_type_configuration}
        /// </remarks>
        [JsiiProperty(name: "jsonTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration? JsonTokenTypeConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>jwt_token_type_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#jwt_token_type_configuration KendraIndex#jwt_token_type_configuration}
        /// </remarks>
        [JsiiProperty(name: "jwtTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration? JwtTokenTypeConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraIndexUserTokenConfigurations), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserTokenConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.KendraIndex.IKendraIndexUserTokenConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>json_token_type_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#json_token_type_configuration KendraIndex#json_token_type_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jsonTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration\"}", isOptional: true)]
            public aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration? JsonTokenTypeConfiguration
            {
                get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration?>();
            }

            /// <summary>jwt_token_type_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#jwt_token_type_configuration KendraIndex#jwt_token_type_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jwtTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration\"}", isOptional: true)]
            public aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration? JwtTokenTypeConfiguration
            {
                get => GetInstanceProperty<aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration?>();
            }
        }
    }
}
