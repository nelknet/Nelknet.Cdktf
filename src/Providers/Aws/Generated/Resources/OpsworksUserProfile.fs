namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksUserProfileState<'SshUsername, 'UserArn> = { assignments: ResizeArray<aws.OpsworksUserProfile.OpsworksUserProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_user_profile">aws_opsworks_user_profile</a>.
    /// </summary>
    type OpsworksUserProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksUserProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksUserProfileState<Missing, Missing>)

        member _.Zero(()) : OpsworksUserProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksUserProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_user_profile#ssh_username-1">OpsworksUserProfile#ssh_username</a>.
        /// </summary>
        [<CustomOperation "ssh_username">]
        member _.SshUsername(state: OpsworksUserProfileState<Missing, 'UserArn>, value: string) : OpsworksUserProfileState<Present, 'UserArn> =
            state.assignments.Add(fun config -> config.SshUsername <- value)
            ({ assignments = state.assignments } : OpsworksUserProfileState<Present, 'UserArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_user_profile#user_arn-1">OpsworksUserProfile#user_arn</a>.
        /// </summary>
        [<CustomOperation "user_arn">]
        member _.UserArn(state: OpsworksUserProfileState<'SshUsername, Missing>, value: string) : OpsworksUserProfileState<'SshUsername, Present> =
            state.assignments.Add(fun config -> config.UserArn <- value)
            ({ assignments = state.assignments } : OpsworksUserProfileState<'SshUsername, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_user_profile#allow_self_management-1">OpsworksUserProfile#allow_self_management</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_self_management">]
        member _.AllowSelfManagement(state: OpsworksUserProfileState<'SshUsername, 'UserArn>, value: bool) : OpsworksUserProfileState<'SshUsername, 'UserArn> =
            state.assignments.Add(fun config -> config.AllowSelfManagement <- value)
            state : OpsworksUserProfileState<'SshUsername, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_user_profile#allow_self_management-1">OpsworksUserProfile#allow_self_management</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_self_management">]
        member _.AllowSelfManagement(state: OpsworksUserProfileState<'SshUsername, 'UserArn>, value: HashiCorp.Cdktf.IResolvable) : OpsworksUserProfileState<'SshUsername, 'UserArn> =
            state.assignments.Add(fun config -> config.AllowSelfManagement <- value)
            state : OpsworksUserProfileState<'SshUsername, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_user_profile#id-1">OpsworksUserProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksUserProfileState<'SshUsername, 'UserArn>, value: string) : OpsworksUserProfileState<'SshUsername, 'UserArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksUserProfileState<'SshUsername, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_user_profile#ssh_public_key-1">OpsworksUserProfile#ssh_public_key</a>.
        /// </summary>
        [<CustomOperation "ssh_public_key">]
        member _.SshPublicKey(state: OpsworksUserProfileState<'SshUsername, 'UserArn>, value: string) : OpsworksUserProfileState<'SshUsername, 'UserArn> =
            state.assignments.Add(fun config -> config.SshPublicKey <- value)
            state : OpsworksUserProfileState<'SshUsername, 'UserArn>

        member _.Run(state: OpsworksUserProfileState<Present, Present>) : aws.OpsworksUserProfile.OpsworksUserProfile =
            let config = aws.OpsworksUserProfile.OpsworksUserProfileConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksUserProfile.OpsworksUserProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksUserProfile: missing required arguments. Must call: ssh_username, user_arn.", 9999, IsError = true)>]
        member _.Run(_: OpsworksUserProfileState<_, _>) : aws.OpsworksUserProfile.OpsworksUserProfile =
            Unchecked.defaultof<aws.OpsworksUserProfile.OpsworksUserProfile>
