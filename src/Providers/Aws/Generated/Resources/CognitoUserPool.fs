namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CognitoUserPoolState<'Name> = { assignments: ResizeArray<aws.CognitoUserPool.CognitoUserPoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool">aws_cognito_user_pool</a>.
    /// </summary>
    type CognitoUserPoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : CognitoUserPoolState<Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolState<Missing>)

        member _.Zero(()) : CognitoUserPoolState<Missing> =
            ({ assignments = ResizeArray() } : CognitoUserPoolState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#name-1">CognitoUserPool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CognitoUserPoolState<Missing>, value: string) : CognitoUserPoolState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CognitoUserPoolState<Present>)

        /// <summary>
        /// account_recovery_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#account_recovery_setting-1">CognitoUserPool#account_recovery_setting</a>
        /// </summary>
        [<CustomOperation "account_recovery_setting">]
        member _.AccountRecoverySetting(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolAccountRecoverySetting) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.AccountRecoverySetting <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// admin_create_user_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#admin_create_user_config-1">CognitoUserPool#admin_create_user_config</a>
        /// </summary>
        [<CustomOperation "admin_create_user_config">]
        member _.AdminCreateUserConfig(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolAdminCreateUserConfig) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.AdminCreateUserConfig <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#alias_attributes-1">CognitoUserPool#alias_attributes</a>.
        /// </summary>
        [<CustomOperation "alias_attributes">]
        member _.AliasAttributes(state: CognitoUserPoolState<'Name>, value: seq<string>) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.AliasAttributes <- (value |> Seq.toArray))
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#auto_verified_attributes-1">CognitoUserPool#auto_verified_attributes</a>.
        /// </summary>
        [<CustomOperation "auto_verified_attributes">]
        member _.AutoVerifiedAttributes(state: CognitoUserPoolState<'Name>, value: seq<string>) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.AutoVerifiedAttributes <- (value |> Seq.toArray))
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#deletion_protection-1">CognitoUserPool#deletion_protection</a>.
        /// </summary>
        [<CustomOperation "deletion_protection">]
        member _.DeletionProtection(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.DeletionProtection <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// device_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#device_configuration-1">CognitoUserPool#device_configuration</a>
        /// </summary>
        [<CustomOperation "device_configuration">]
        member _.DeviceConfiguration(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolDeviceConfiguration) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.DeviceConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// email_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_configuration-1">CognitoUserPool#email_configuration</a>
        /// </summary>
        [<CustomOperation "email_configuration">]
        member _.EmailConfiguration(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolEmailConfiguration) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.EmailConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// email_mfa_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_mfa_configuration-1">CognitoUserPool#email_mfa_configuration</a>
        /// </summary>
        [<CustomOperation "email_mfa_configuration">]
        member _.EmailMfaConfiguration(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolEmailMfaConfiguration) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.EmailMfaConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_message-1">CognitoUserPool#email_verification_message</a>.
        /// </summary>
        [<CustomOperation "email_verification_message">]
        member _.EmailVerificationMessage(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.EmailVerificationMessage <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_subject-1">CognitoUserPool#email_verification_subject</a>.
        /// </summary>
        [<CustomOperation "email_verification_subject">]
        member _.EmailVerificationSubject(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.EmailVerificationSubject <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#id-1">CognitoUserPool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// lambda_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_config-1">CognitoUserPool#lambda_config</a>
        /// </summary>
        [<CustomOperation "lambda_config">]
        member _.LambdaConfig(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolLambdaConfig) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.LambdaConfig <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#mfa_configuration-1">CognitoUserPool#mfa_configuration</a>.
        /// </summary>
        [<CustomOperation "mfa_configuration">]
        member _.MfaConfiguration(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.MfaConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// password_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#password_policy-1">CognitoUserPool#password_policy</a>
        /// </summary>
        [<CustomOperation "password_policy">]
        member _.PasswordPolicy(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolPasswordPolicy) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.PasswordPolicy <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// schema block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#schema-1">CognitoUserPool#schema</a> Accepts: aws.IResolvable | aws.CognitoUserPool.CognitoUserPoolSchema[]
        /// </summary>
        [<CustomOperation "schema">]
        member _.Schema(state: CognitoUserPoolState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.Schema <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// sign_in_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sign_in_policy-1">CognitoUserPool#sign_in_policy</a>
        /// </summary>
        [<CustomOperation "sign_in_policy">]
        member _.SignInPolicy(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolSignInPolicy) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.SignInPolicy <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_authentication_message-1">CognitoUserPool#sms_authentication_message</a>.
        /// </summary>
        [<CustomOperation "sms_authentication_message">]
        member _.SmsAuthenticationMessage(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.SmsAuthenticationMessage <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// sms_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_configuration-1">CognitoUserPool#sms_configuration</a>
        /// </summary>
        [<CustomOperation "sms_configuration">]
        member _.SmsConfiguration(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolSmsConfiguration) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.SmsConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_verification_message-1">CognitoUserPool#sms_verification_message</a>.
        /// </summary>
        [<CustomOperation "sms_verification_message">]
        member _.SmsVerificationMessage(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.SmsVerificationMessage <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// software_token_mfa_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#software_token_mfa_configuration-1">CognitoUserPool#software_token_mfa_configuration</a>
        /// </summary>
        [<CustomOperation "software_token_mfa_configuration">]
        member _.SoftwareTokenMfaConfiguration(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfiguration) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.SoftwareTokenMfaConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags-1">CognitoUserPool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CognitoUserPoolState<'Name>, value: seq<string * string>) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags_all-1">CognitoUserPool#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CognitoUserPoolState<'Name>, value: seq<string * string>) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// user_attribute_update_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_attribute_update_settings-1">CognitoUserPool#user_attribute_update_settings</a>
        /// </summary>
        [<CustomOperation "user_attribute_update_settings">]
        member _.UserAttributeUpdateSettings(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.UserAttributeUpdateSettings <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_attributes-1">CognitoUserPool#username_attributes</a>.
        /// </summary>
        [<CustomOperation "username_attributes">]
        member _.UsernameAttributes(state: CognitoUserPoolState<'Name>, value: seq<string>) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.UsernameAttributes <- (value |> Seq.toArray))
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// username_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_configuration-1">CognitoUserPool#username_configuration</a>
        /// </summary>
        [<CustomOperation "username_configuration">]
        member _.UsernameConfiguration(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolUsernameConfiguration) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.UsernameConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// user_pool_add_ons block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_add_ons-1">CognitoUserPool#user_pool_add_ons</a>
        /// </summary>
        [<CustomOperation "user_pool_add_ons">]
        member _.UserPoolAddOns(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolUserPoolAddOns) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.UserPoolAddOns <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_tier-1">CognitoUserPool#user_pool_tier</a>.
        /// </summary>
        [<CustomOperation "user_pool_tier">]
        member _.UserPoolTier(state: CognitoUserPoolState<'Name>, value: string) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.UserPoolTier <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// verification_message_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#verification_message_template-1">CognitoUserPool#verification_message_template</a>
        /// </summary>
        [<CustomOperation "verification_message_template">]
        member _.VerificationMessageTemplate(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolVerificationMessageTemplate) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.VerificationMessageTemplate <- value)
            state : CognitoUserPoolState<'Name>

        /// <summary>
        /// web_authn_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#web_authn_configuration-1">CognitoUserPool#web_authn_configuration</a>
        /// </summary>
        [<CustomOperation "web_authn_configuration">]
        member _.WebAuthnConfiguration(state: CognitoUserPoolState<'Name>, value: aws.CognitoUserPool.CognitoUserPoolWebAuthnConfiguration) : CognitoUserPoolState<'Name> =
            state.assignments.Add(fun config -> config.WebAuthnConfiguration <- value)
            state : CognitoUserPoolState<'Name>

        member _.Run(state: CognitoUserPoolState<Present>) : aws.CognitoUserPool.CognitoUserPool =
            let config = aws.CognitoUserPool.CognitoUserPoolConfig()
            for setter in state.assignments do
                setter config
            aws.CognitoUserPool.CognitoUserPool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cognitoUserPool: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CognitoUserPoolState<_>) : aws.CognitoUserPool.CognitoUserPool =
            Unchecked.defaultof<aws.CognitoUserPool.CognitoUserPool>
