namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type WorkspaceswebNetworkSettingsState<'SecurityGroupIds, 'SubnetIds, 'VpcId> = { assignments: ResizeArray<aws.WorkspaceswebNetworkSettings.WorkspaceswebNetworkSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_network_settings">aws_workspacesweb_network_settings</a>.
    /// </summary>
    type WorkspaceswebNetworkSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : WorkspaceswebNetworkSettingsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebNetworkSettingsState<Missing, Missing, Missing>)

        member _.Zero(()) : WorkspaceswebNetworkSettingsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : WorkspaceswebNetworkSettingsState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_network_settings#security_group_ids-1">WorkspaceswebNetworkSettings#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: WorkspaceswebNetworkSettingsState<Missing, 'SubnetIds, 'VpcId>, value: seq<string>) : WorkspaceswebNetworkSettingsState<Present, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : WorkspaceswebNetworkSettingsState<Present, 'SubnetIds, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_network_settings#subnet_ids-1">WorkspaceswebNetworkSettings#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: WorkspaceswebNetworkSettingsState<'SecurityGroupIds, Missing, 'VpcId>, value: seq<string>) : WorkspaceswebNetworkSettingsState<'SecurityGroupIds, Present, 'VpcId> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : WorkspaceswebNetworkSettingsState<'SecurityGroupIds, Present, 'VpcId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_network_settings#vpc_id-1">WorkspaceswebNetworkSettings#vpc_id</a>.
        /// </summary>
        [<CustomOperation "vpc_id">]
        member _.VpcId(state: WorkspaceswebNetworkSettingsState<'SecurityGroupIds, 'SubnetIds, Missing>, value: string) : WorkspaceswebNetworkSettingsState<'SecurityGroupIds, 'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.VpcId <- value)
            ({ assignments = state.assignments } : WorkspaceswebNetworkSettingsState<'SecurityGroupIds, 'SubnetIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/workspacesweb_network_settings#tags-1">WorkspaceswebNetworkSettings#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: WorkspaceswebNetworkSettingsState<'SecurityGroupIds, 'SubnetIds, 'VpcId>, value: seq<string * string>) : WorkspaceswebNetworkSettingsState<'SecurityGroupIds, 'SubnetIds, 'VpcId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : WorkspaceswebNetworkSettingsState<'SecurityGroupIds, 'SubnetIds, 'VpcId>

        member _.Run(state: WorkspaceswebNetworkSettingsState<Present, Present, Present>) : aws.WorkspaceswebNetworkSettings.WorkspaceswebNetworkSettings =
            let config = aws.WorkspaceswebNetworkSettings.WorkspaceswebNetworkSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.WorkspaceswebNetworkSettings.WorkspaceswebNetworkSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.workspaceswebNetworkSettings: missing required arguments. Must call: security_group_ids, subnet_ids, vpc_id.", 9999, IsError = true)>]
        member _.Run(_: WorkspaceswebNetworkSettingsState<_, _, _>) : aws.WorkspaceswebNetworkSettings.WorkspaceswebNetworkSettings =
            Unchecked.defaultof<aws.WorkspaceswebNetworkSettings.WorkspaceswebNetworkSettings>
