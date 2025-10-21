namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerUserProfileState<'DomainId, 'UserProfileName> = { assignments: ResizeArray<aws.SagemakerUserProfile.SagemakerUserProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile">aws_sagemaker_user_profile</a>.
    /// </summary>
    type SagemakerUserProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerUserProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerUserProfileState<Missing, Missing>)

        member _.Zero(()) : SagemakerUserProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerUserProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#domain_id-1">SagemakerUserProfile#domain_id</a>.
        /// </summary>
        [<CustomOperation "domain_id">]
        member _.DomainId(state: SagemakerUserProfileState<Missing, 'UserProfileName>, value: string) : SagemakerUserProfileState<Present, 'UserProfileName> =
            state.assignments.Add(fun config -> config.DomainId <- value)
            ({ assignments = state.assignments } : SagemakerUserProfileState<Present, 'UserProfileName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#user_profile_name-1">SagemakerUserProfile#user_profile_name</a>.
        /// </summary>
        [<CustomOperation "user_profile_name">]
        member _.UserProfileName(state: SagemakerUserProfileState<'DomainId, Missing>, value: string) : SagemakerUserProfileState<'DomainId, Present> =
            state.assignments.Add(fun config -> config.UserProfileName <- value)
            ({ assignments = state.assignments } : SagemakerUserProfileState<'DomainId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#id-1">SagemakerUserProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerUserProfileState<'DomainId, 'UserProfileName>, value: string) : SagemakerUserProfileState<'DomainId, 'UserProfileName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerUserProfileState<'DomainId, 'UserProfileName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#single_sign_on_user_identifier-1">SagemakerUserProfile#single_sign_on_user_identifier</a>.
        /// </summary>
        [<CustomOperation "single_sign_on_user_identifier">]
        member _.SingleSignOnUserIdentifier(state: SagemakerUserProfileState<'DomainId, 'UserProfileName>, value: string) : SagemakerUserProfileState<'DomainId, 'UserProfileName> =
            state.assignments.Add(fun config -> config.SingleSignOnUserIdentifier <- value)
            state : SagemakerUserProfileState<'DomainId, 'UserProfileName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#single_sign_on_user_value-1">SagemakerUserProfile#single_sign_on_user_value</a>.
        /// </summary>
        [<CustomOperation "single_sign_on_user_value">]
        member _.SingleSignOnUserValue(state: SagemakerUserProfileState<'DomainId, 'UserProfileName>, value: string) : SagemakerUserProfileState<'DomainId, 'UserProfileName> =
            state.assignments.Add(fun config -> config.SingleSignOnUserValue <- value)
            state : SagemakerUserProfileState<'DomainId, 'UserProfileName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#tags-1">SagemakerUserProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerUserProfileState<'DomainId, 'UserProfileName>, value: seq<string * string>) : SagemakerUserProfileState<'DomainId, 'UserProfileName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerUserProfileState<'DomainId, 'UserProfileName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#tags_all-1">SagemakerUserProfile#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerUserProfileState<'DomainId, 'UserProfileName>, value: seq<string * string>) : SagemakerUserProfileState<'DomainId, 'UserProfileName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerUserProfileState<'DomainId, 'UserProfileName>

        /// <summary>
        /// user_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#user_settings-1">SagemakerUserProfile#user_settings</a>
        /// </summary>
        [<CustomOperation "user_settings">]
        member _.UserSettings(state: SagemakerUserProfileState<'DomainId, 'UserProfileName>, value: aws.SagemakerUserProfile.SagemakerUserProfileUserSettings) : SagemakerUserProfileState<'DomainId, 'UserProfileName> =
            state.assignments.Add(fun config -> config.UserSettings <- value)
            state : SagemakerUserProfileState<'DomainId, 'UserProfileName>

        member _.Run(state: SagemakerUserProfileState<Present, Present>) : aws.SagemakerUserProfile.SagemakerUserProfile =
            let config = aws.SagemakerUserProfile.SagemakerUserProfileConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerUserProfile.SagemakerUserProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerUserProfile: missing required arguments. Must call: domain_id, user_profile_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerUserProfileState<_, _>) : aws.SagemakerUserProfile.SagemakerUserProfile =
            Unchecked.defaultof<aws.SagemakerUserProfile.SagemakerUserProfile>
