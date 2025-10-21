namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User> = { assignments: ResizeArray<aws.DatasyncLocationSmb.DatasyncLocationSmbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb">aws_datasync_location_smb</a>.
    /// </summary>
    type DatasyncLocationSmbBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationSmbState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationSmbState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationSmbState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationSmbState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#agent_arns-1">DatasyncLocationSmb#agent_arns</a>.
        /// </summary>
        [<CustomOperation "agent_arns">]
        member _.AgentArns(state: DatasyncLocationSmbState<Missing, 'Password, 'ServerHostname, 'Subdirectory, 'User>, value: seq<string>) : DatasyncLocationSmbState<Present, 'Password, 'ServerHostname, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.AgentArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : DatasyncLocationSmbState<Present, 'Password, 'ServerHostname, 'Subdirectory, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#password-1">DatasyncLocationSmb#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: DatasyncLocationSmbState<'AgentArns, Missing, 'ServerHostname, 'Subdirectory, 'User>, value: string) : DatasyncLocationSmbState<'AgentArns, Present, 'ServerHostname, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : DatasyncLocationSmbState<'AgentArns, Present, 'ServerHostname, 'Subdirectory, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#server_hostname-1">DatasyncLocationSmb#server_hostname</a>.
        /// </summary>
        [<CustomOperation "server_hostname">]
        member _.ServerHostname(state: DatasyncLocationSmbState<'AgentArns, 'Password, Missing, 'Subdirectory, 'User>, value: string) : DatasyncLocationSmbState<'AgentArns, 'Password, Present, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.ServerHostname <- value)
            ({ assignments = state.assignments } : DatasyncLocationSmbState<'AgentArns, 'Password, Present, 'Subdirectory, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#subdirectory-1">DatasyncLocationSmb#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, Missing, 'User>, value: string) : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, Present, 'User> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            ({ assignments = state.assignments } : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, Present, 'User>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#user-1">DatasyncLocationSmb#user</a>.
        /// </summary>
        [<CustomOperation "user">]
        member _.User(state: DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, Missing>, value: string) : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, Present> =
            state.assignments.Add(fun config -> config.User <- value)
            ({ assignments = state.assignments } : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#domain-1">DatasyncLocationSmb#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>, value: string) : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#id-1">DatasyncLocationSmb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>, value: string) : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>

        /// <summary>
        /// mount_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#mount_options-1">DatasyncLocationSmb#mount_options</a>
        /// </summary>
        [<CustomOperation "mount_options">]
        member _.MountOptions(state: DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>, value: aws.DatasyncLocationSmb.DatasyncLocationSmbMountOptions) : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.MountOptions <- value)
            state : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#tags-1">DatasyncLocationSmb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>, value: seq<string * string>) : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#tags_all-1">DatasyncLocationSmb#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>, value: seq<string * string>) : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationSmbState<'AgentArns, 'Password, 'ServerHostname, 'Subdirectory, 'User>

        member _.Run(state: DatasyncLocationSmbState<Present, Present, Present, Present, Present>) : aws.DatasyncLocationSmb.DatasyncLocationSmb =
            let config = aws.DatasyncLocationSmb.DatasyncLocationSmbConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationSmb.DatasyncLocationSmb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationSmb: missing required arguments. Must call: agent_arns, password, server_hostname, subdirectory, user.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationSmbState<_, _, _, _, _>) : aws.DatasyncLocationSmb.DatasyncLocationSmb =
            Unchecked.defaultof<aws.DatasyncLocationSmb.DatasyncLocationSmb>
