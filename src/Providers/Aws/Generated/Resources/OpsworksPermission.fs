namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpsworksPermissionState<'StackId, 'UserArn> = { assignments: ResizeArray<aws.OpsworksPermission.OpsworksPermissionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission">aws_opsworks_permission</a>.
    /// </summary>
    type OpsworksPermissionBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpsworksPermissionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksPermissionState<Missing, Missing>)

        member _.Zero(()) : OpsworksPermissionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpsworksPermissionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#stack_id-1">OpsworksPermission#stack_id</a>.
        /// </summary>
        [<CustomOperation "stack_id">]
        member _.StackId(state: OpsworksPermissionState<Missing, 'UserArn>, value: string) : OpsworksPermissionState<Present, 'UserArn> =
            state.assignments.Add(fun config -> config.StackId <- value)
            ({ assignments = state.assignments } : OpsworksPermissionState<Present, 'UserArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#user_arn-1">OpsworksPermission#user_arn</a>.
        /// </summary>
        [<CustomOperation "user_arn">]
        member _.UserArn(state: OpsworksPermissionState<'StackId, Missing>, value: string) : OpsworksPermissionState<'StackId, Present> =
            state.assignments.Add(fun config -> config.UserArn <- value)
            ({ assignments = state.assignments } : OpsworksPermissionState<'StackId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#allow_ssh-1">OpsworksPermission#allow_ssh</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_ssh">]
        member _.AllowSsh(state: OpsworksPermissionState<'StackId, 'UserArn>, value: bool) : OpsworksPermissionState<'StackId, 'UserArn> =
            state.assignments.Add(fun config -> config.AllowSsh <- value)
            state : OpsworksPermissionState<'StackId, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#allow_ssh-1">OpsworksPermission#allow_ssh</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_ssh">]
        member _.AllowSsh(state: OpsworksPermissionState<'StackId, 'UserArn>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPermissionState<'StackId, 'UserArn> =
            state.assignments.Add(fun config -> config.AllowSsh <- value)
            state : OpsworksPermissionState<'StackId, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#allow_sudo-1">OpsworksPermission#allow_sudo</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_sudo">]
        member _.AllowSudo(state: OpsworksPermissionState<'StackId, 'UserArn>, value: bool) : OpsworksPermissionState<'StackId, 'UserArn> =
            state.assignments.Add(fun config -> config.AllowSudo <- value)
            state : OpsworksPermissionState<'StackId, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#allow_sudo-1">OpsworksPermission#allow_sudo</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "allow_sudo">]
        member _.AllowSudo(state: OpsworksPermissionState<'StackId, 'UserArn>, value: HashiCorp.Cdktf.IResolvable) : OpsworksPermissionState<'StackId, 'UserArn> =
            state.assignments.Add(fun config -> config.AllowSudo <- value)
            state : OpsworksPermissionState<'StackId, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#id-1">OpsworksPermission#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpsworksPermissionState<'StackId, 'UserArn>, value: string) : OpsworksPermissionState<'StackId, 'UserArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpsworksPermissionState<'StackId, 'UserArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opsworks_permission#level-1">OpsworksPermission#level</a>.
        /// </summary>
        [<CustomOperation "level">]
        member _.Level(state: OpsworksPermissionState<'StackId, 'UserArn>, value: string) : OpsworksPermissionState<'StackId, 'UserArn> =
            state.assignments.Add(fun config -> config.Level <- value)
            state : OpsworksPermissionState<'StackId, 'UserArn>

        member _.Run(state: OpsworksPermissionState<Present, Present>) : aws.OpsworksPermission.OpsworksPermission =
            let config = aws.OpsworksPermission.OpsworksPermissionConfig()
            for setter in state.assignments do
                setter config
            aws.OpsworksPermission.OpsworksPermission(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opsworksPermission: missing required arguments. Must call: stack_id, user_arn.", 9999, IsError = true)>]
        member _.Run(_: OpsworksPermissionState<_, _>) : aws.OpsworksPermission.OpsworksPermission =
            Unchecked.defaultof<aws.OpsworksPermission.OpsworksPermission>
