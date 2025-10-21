namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier> = { assignments: ResizeArray<aws.DatazoneUserProfile.DatazoneUserProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_user_profile">aws_datazone_user_profile</a>.
    /// </summary>
    type DatazoneUserProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatazoneUserProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneUserProfileState<Missing, Missing>)

        member _.Zero(()) : DatazoneUserProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DatazoneUserProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_user_profile#domain_identifier-1">DatazoneUserProfile#domain_identifier</a>.
        /// </summary>
        [<CustomOperation "domain_identifier">]
        member _.DomainIdentifier(state: DatazoneUserProfileState<Missing, 'UserIdentifier>, value: string) : DatazoneUserProfileState<Present, 'UserIdentifier> =
            state.assignments.Add(fun config -> config.DomainIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneUserProfileState<Present, 'UserIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_user_profile#user_identifier-1">DatazoneUserProfile#user_identifier</a>.
        /// </summary>
        [<CustomOperation "user_identifier">]
        member _.UserIdentifier(state: DatazoneUserProfileState<'DomainIdentifier, Missing>, value: string) : DatazoneUserProfileState<'DomainIdentifier, Present> =
            state.assignments.Add(fun config -> config.UserIdentifier <- value)
            ({ assignments = state.assignments } : DatazoneUserProfileState<'DomainIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_user_profile#status-1">DatazoneUserProfile#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier>, value: string) : DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_user_profile#timeouts-1">DatazoneUserProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier>, value: aws.DatazoneUserProfile.DatazoneUserProfileTimeouts) : DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datazone_user_profile#user_type-1">DatazoneUserProfile#user_type</a>.
        /// </summary>
        [<CustomOperation "user_type">]
        member _.UserType(state: DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier>, value: string) : DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier> =
            state.assignments.Add(fun config -> config.UserType <- value)
            state : DatazoneUserProfileState<'DomainIdentifier, 'UserIdentifier>

        member _.Run(state: DatazoneUserProfileState<Present, Present>) : aws.DatazoneUserProfile.DatazoneUserProfile =
            let config = aws.DatazoneUserProfile.DatazoneUserProfileConfig()
            for setter in state.assignments do
                setter config
            aws.DatazoneUserProfile.DatazoneUserProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datazoneUserProfile: missing required arguments. Must call: domain_identifier, user_identifier.", 9999, IsError = true)>]
        member _.Run(_: DatazoneUserProfileState<_, _>) : aws.DatazoneUserProfile.DatazoneUserProfile =
            Unchecked.defaultof<aws.DatazoneUserProfile.DatazoneUserProfile>
