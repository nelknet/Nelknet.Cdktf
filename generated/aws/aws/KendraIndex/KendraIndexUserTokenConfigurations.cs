using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiByValue(fqn: "aws.kendraIndex.KendraIndexUserTokenConfigurations")]
    public class KendraIndexUserTokenConfigurations : aws.KendraIndex.IKendraIndexUserTokenConfigurations
    {
        /// <summary>json_token_type_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#json_token_type_configuration KendraIndex#json_token_type_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jsonTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration\"}", isOptional: true)]
        public aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration? JsonTokenTypeConfiguration
        {
            get;
            set;
        }

        /// <summary>jwt_token_type_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#jwt_token_type_configuration KendraIndex#jwt_token_type_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jwtTokenTypeConfiguration", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration\"}", isOptional: true)]
        public aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration? JwtTokenTypeConfiguration
        {
            get;
            set;
        }
    }
}
