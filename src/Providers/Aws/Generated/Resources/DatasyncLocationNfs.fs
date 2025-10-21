namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory> = { assignments: ResizeArray<aws.DatasyncLocationNfs.DatasyncLocationNfsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs">aws_datasync_location_nfs</a>.
    /// </summary>
    type DatasyncLocationNfsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationNfsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationNfsState<Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationNfsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationNfsState<Missing, Missing, Missing>)

        /// <summary>
        /// on_prem_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#on_prem_config-1">DatasyncLocationNfs#on_prem_config</a>
        /// </summary>
        [<CustomOperation "on_prem_config">]
        member _.OnPremConfig(state: DatasyncLocationNfsState<Missing, 'ServerHostname, 'Subdirectory>, value: aws.DatasyncLocationNfs.DatasyncLocationNfsOnPremConfig) : DatasyncLocationNfsState<Present, 'ServerHostname, 'Subdirectory> =
            state.assignments.Add(fun config -> config.OnPremConfig <- value)
            ({ assignments = state.assignments } : DatasyncLocationNfsState<Present, 'ServerHostname, 'Subdirectory>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#server_hostname-1">DatasyncLocationNfs#server_hostname</a>.
        /// </summary>
        [<CustomOperation "server_hostname">]
        member _.ServerHostname(state: DatasyncLocationNfsState<'OnPremConfig, Missing, 'Subdirectory>, value: string) : DatasyncLocationNfsState<'OnPremConfig, Present, 'Subdirectory> =
            state.assignments.Add(fun config -> config.ServerHostname <- value)
            ({ assignments = state.assignments } : DatasyncLocationNfsState<'OnPremConfig, Present, 'Subdirectory>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#subdirectory-1">DatasyncLocationNfs#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, Missing>, value: string) : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, Present> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            ({ assignments = state.assignments } : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#id-1">DatasyncLocationNfs#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>, value: string) : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>

        /// <summary>
        /// mount_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#mount_options-1">DatasyncLocationNfs#mount_options</a>
        /// </summary>
        [<CustomOperation "mount_options">]
        member _.MountOptions(state: DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>, value: aws.DatasyncLocationNfs.DatasyncLocationNfsMountOptions) : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory> =
            state.assignments.Add(fun config -> config.MountOptions <- value)
            state : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#tags-1">DatasyncLocationNfs#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>, value: seq<string * string>) : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#tags_all-1">DatasyncLocationNfs#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>, value: seq<string * string>) : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationNfsState<'OnPremConfig, 'ServerHostname, 'Subdirectory>

        member _.Run(state: DatasyncLocationNfsState<Present, Present, Present>) : aws.DatasyncLocationNfs.DatasyncLocationNfs =
            let config = aws.DatasyncLocationNfs.DatasyncLocationNfsConfig()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationNfs.DatasyncLocationNfs(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationNfs: missing required arguments. Must call: on_prem_config, server_hostname, subdirectory.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationNfsState<_, _, _>) : aws.DatasyncLocationNfs.DatasyncLocationNfs =
            Unchecked.defaultof<aws.DatasyncLocationNfs.DatasyncLocationNfs>
